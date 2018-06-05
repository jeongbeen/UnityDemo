using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnityDemo.Models;
using UnityDemo.Models.Scorers;

namespace Assets.Tests
{
    class BasicScorerTest_최정빈
    {
        [Test]
        public void 두_카드의_숫자의_합이_10보다_작은_경우()
        {
            Scorer scorer = new BasicScorer();
            Player p1 = new Player("1");
            p1.AddCard(new Card(3, false));
            p1.AddCard(new Card(4, false));

            Player p2 = new Player("2");
            p2.AddCard(new Card(4, false));
            p2.AddCard(new Card(4, false));

            Player winner = scorer.GetWinner(p1, p2);

            Assert.AreEqual(p2, winner);
        }

        [Test]
        public void 땡의_조합의_경우()
        {
            Scorer scorer = new BasicScorer();
            Player p1 = new Player("1");
            p1.AddCard(new Card(3, true));
            p1.AddCard(new Card(8, true));

            Player p2 = new Player("2");
            p2.AddCard(new Card(10, true));
            p2.AddCard(new Card(10, true));

            Player winner = scorer.GetWinner(p1, p2);

            Assert.AreEqual(p1, winner);
        }
    }
}
