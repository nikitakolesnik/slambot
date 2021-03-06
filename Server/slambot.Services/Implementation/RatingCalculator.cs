﻿using slambot.Common.Enums;
using System;

namespace slambot.Services.Implementation
{
	public class RatingCalculator : IRatingCalculator
	{
		public int PlayerRating(int playerRating, int opponentRating, int maxRatingDiff, MatchResult matchResult)
		{
			// Huge thanks again to Candyboy & Eight Bit for the formula & implementation, carried over from the GvGRank project

			const double EULERS_NUMBER = 2.71828;
			const double MIN_CHANGE_PERCENT = 0.01;  // Minimum rating change for a comparison
			const double EVEN_CHANGE_PERCENT = 0.025; // Rating change for an even comparison
			const double MAX_CHANGE_PERCENT = 0.05;  // Maximum rating change for a comparison

			int ratingDiff = Math.Max(Math.Abs(playerRating - opponentRating), 100);
			double quotient = ratingDiff / Math.Max(maxRatingDiff, 1);
			int ratingChange;

			if (playerRating < opponentRating) // Unexpected result
			{
				ratingChange = Convert.ToInt32(ratingDiff * Math.Max(EVEN_CHANGE_PERCENT * Math.Pow(EULERS_NUMBER, 2 * Math.Log(MIN_CHANGE_PERCENT / EVEN_CHANGE_PERCENT) * quotient), MIN_CHANGE_PERCENT));
			}
			else // Expected result
			{
				ratingChange = Convert.ToInt32(ratingDiff * Math.Min(EVEN_CHANGE_PERCENT * Math.Pow(EULERS_NUMBER, 2 * Math.Log(MAX_CHANGE_PERCENT / EVEN_CHANGE_PERCENT) * quotient), MAX_CHANGE_PERCENT));
			}

			return (matchResult == MatchResult.Win) ? playerRating + ratingChange : playerRating - ratingChange;
		}
	}
}
