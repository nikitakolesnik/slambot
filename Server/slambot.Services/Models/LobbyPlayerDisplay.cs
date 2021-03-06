﻿using slambot.Common.Enums;
using System;

namespace slambot.Services.Models
{
	public class LobbyPlayerDisplay
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Rating { get; set; }
		public TeamNumber TeamNumber { get; set; }
		public DateTime Joined { get; set; }
	}
}
