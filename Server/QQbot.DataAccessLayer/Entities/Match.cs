﻿using QQbot.DataAccessLayer.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QQbot.DataAccessLayer.Entities
{
	[Table("Matches")]
	public class Match
	{
		[Key]
		public int Id { get; set; }

		public DateTime When { get; set; } = DateTime.UtcNow;

		public Team WinningTeam { get; set; }

		public Team LosingTeam { get; set; }

		public Status Status { get; set; } = Status.Active;
	}
}
