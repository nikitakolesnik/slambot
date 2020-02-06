﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QQbot.Api.Contexts;
using QQbot.Api.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QQbot.Api.Entities;
using QQbot.Api.Enums;

namespace QQbot.Api.Services
{
	public class MatchRepository : IMatchRepository
	{
		private readonly ApplicationDbContext _context;
		private readonly IRatingCalculator _calc;

		public MatchRepository(ApplicationDbContext context, IRatingCalculator calc)
		{
			_context = context ?? throw new ArgumentNullException(nameof(context));
			_calc    = calc    ?? throw new ArgumentNullException(nameof(calc));
		}

		private async Task<IEnumerable<Player>> GetPlayerInfoAsync(string[] names)
		{
			return await _context.Players
				.Where(p => names.Contains(p.Name, StringComparer.CurrentCultureIgnoreCase))
				.ToListAsync();
		}

		public async Task<int> RecordMatchAsync(string[] winNameList, string[] loseNameList)
		{
			// Get player info for both teams

			IEnumerable<Player> playersWin  = await GetPlayerInfoAsync(winNameList);
			IEnumerable<Player> playersLose = await GetPlayerInfoAsync(loseNameList);


			// Create & Insert new teams

			Team teamWin  = new Team();
			Team teamLose = new Team();

			await _context.Teams.AddAsync(teamWin);
			await _context.Teams.AddAsync(teamLose);
			await _context.SaveChangesAsync();


			// Create & Insert the match

			await _context.Matches.AddAsync(new Match { WinningTeam = teamWin, LosingTeam = teamLose });


			// Calculate rating change, create TeamPlayer objects, save rating before & after

			IEnumerable<TeamPlayer> teamPlayers = Enumerable.Empty<TeamPlayer>();

			double winTeamRating  = _calc.TeamRating(playersWin);
			double loseTeamRating = _calc.TeamRating(playersLose);

			foreach (Player player in playersWin)
			{
				TeamPlayer teamPlayer = new TeamPlayer { Player = player, RatingBefore = player.Rating, Team = teamWin };

				player.Rating = _calc.PlayerRating(player.Rating, loseTeamRating, MatchResult.Win);
				teamPlayer.RatingAfter = player.Rating;
				teamPlayers.Append(teamPlayer);
			}
			foreach (Player player in playersLose)
			{
				TeamPlayer teamPlayer = new TeamPlayer { Player = player, RatingBefore = player.Rating, Team = teamLose };

				player.Rating = _calc.PlayerRating(player.Rating, winTeamRating,  MatchResult.Lose);
				teamPlayer.RatingAfter = player.Rating;
				teamPlayers.Append(teamPlayer);
			}


			// Insert TeamPlayer rows

			foreach(TeamPlayer teamPlayer in teamPlayers)
			{
				await _context.AddAsync(teamPlayer);
			}


			// Done

			return await _context.SaveChangesAsync();
		}
	}
}
