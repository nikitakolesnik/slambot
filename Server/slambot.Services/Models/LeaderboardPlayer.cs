﻿namespace slambot.Services.Models
{
	public class LeaderboardPlayer
	{
		public int Id { get; set; } // For building the profile link
		public int Rank { get; set; }
		public string Name { get; set; }
		public int Rating { get; set; }
	}
}
