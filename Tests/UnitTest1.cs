using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddPlayer()
        {
            var roster = new Roster();
            var newPlayer = new Player();

            roster.AddPlayer(newPlayer);

            Assert.IsTrue(roster.Contains(newPlayer));
        }
    }

    internal class Player
    {
        public string Name { get; set; }
        public Rank Rank { get; set; }
        public Player(string name, Rank rank)
        {
            Name = name;
            Rank = rank;
        }
    }

    internal class Roster
    {
        private readonly List<Player> _players = new();
        public Roster()
        {
        }

        internal void AddPlayer(Player newPlayer)
        {
            _players.Add(newPlayer);
        }


        internal bool Contains(Player player)
        {
            return _players.Contains(player);
        }
    }

    enum Rank
    {
        New = 0,
        Novice,
        Competent,
        Proficient,
        Advanced
    }
}