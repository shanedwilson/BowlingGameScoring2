using BowlingGameScoring2;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class tests_for_various_bowling_score_scenarios
    {
        BowlingGame game = new BowlingGame();


        [Fact]
        public void can_create_game()
        {
            var game = new BowlingGame();
        }

        [Fact]
        public void can_roll_gutter_game()
        {
            RollMany(0, 20);

            Assert.Equal(0, game.Score);
        }

        [Fact]
        public void can_roll_all_ones()
        {
            RollMany(1, 20);

            Assert.Equal(20, game.Score);
        }

        [Fact]
        public void can_roll_spare()
        {
            game.Roll(5);
            game.Roll(5);
            game.Roll(3);
            RollMany(0, 17);

            Assert.Equal(16, game.Score);
        }

        [Fact]
        public void can_roll_strike()
        {
            game.Roll(10);
            game.Roll(3);
            game.Roll(4);
            RollMany(0, 16);

            Assert.Equal(24, game.Score);
        }

        [Fact]
        public void can_roll_perfect_game()
        {
            RollMany(10, 12);

            Assert.Equal(300, game.Score);
        }

        private void RollMany(int pins, int rolls)
        {
            for (var i = 0; i < rolls; i++)
            {
                game.Roll(pins);
            }
        }
    }
}
