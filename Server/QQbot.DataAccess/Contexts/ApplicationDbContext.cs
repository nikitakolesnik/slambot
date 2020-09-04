﻿using Microsoft.EntityFrameworkCore;
using QQbot.DataAccess.Data;
using QQbot.DataAccess.Entities;
using QQbot.Enums;
using System.Collections.Generic;

namespace QQbot.DataAccess.Contexts
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<AdminAction> AdminActions { get; set; }
		public DbSet<LobbyPlayer> LobbyPlayers { get; set; }
		public DbSet<Match>       Matches      { get; set; }
		public DbSet<Player>      Players      { get; set; }
		public DbSet<TeamPlayer>  TeamPlayers  { get; set; }
		public DbSet<Team>        Teams        { get; set; }

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Player>(b =>
			{
				b.HasIndex(p => p.Name).IsUnique();
				b.HasIndex(p => p.Discord).IsUnique();
			});

            modelBuilder.Entity<LobbyPlayer>(b =>
            {
                b.HasIndex(lp => lp.PlayerId).IsUnique();
            });

            IEnumerable<Player> players = HardCodedPlayerData.GetPlayers();
			foreach (var player in players)
			{
				modelBuilder.Entity<Player>().HasData(player);
				modelBuilder.Entity<AdminAction>().HasData(new AdminAction 
				{ 
					Id = player.Id, 
					AdminId = 1, 
					Type = AdminActionType.ActionPlayer, 
					SubjectPlayerId = player.Id 
				});
			}
		}
	}
}
