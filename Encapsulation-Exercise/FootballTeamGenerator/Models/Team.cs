﻿using System;
using System.Xml.Linq;

namespace FootballTeamGenerator.Models
{
	public class Team
	{
        private const string NameEmptyExeptionsMessage = "A name should not be empty.";
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            players = new List<Player>();
            Name = name;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(NameEmptyExeptionsMessage);
                }
                name = value;
            }
        }
        public double Rating
        {
            get
            {
                if (players.Any())
                {
                    return players.Average(x => x.Stats);
                }
                return 0;
            }
        }

        public void AddPlayer(Player player) => players.Add(player);
        public void RemovePlayer(string playerName)
        {
            Player player = players.FirstOrDefault(x => x.Name == playerName);
            if (player == null)
            {
                throw new ArgumentException($"Player {playerName} is not in {Name} team.");
            }
            players.Remove(player);
        }
    }
}

