using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges.c5_arrays_extended;

namespace Tests
{
    [TestClass]
    public class Test_CalculateCrosses
    {
        private Challenge challenge;

        [TestInitialize]
        public void SetUp()
        {
            challenge = new Challenge();
        }

        [TestMethod]
        public void ValidGame_CalculatesCorrectCrosses()
        {
            int[,] game = {{0, 1, -1},
                {0, 1, -1},
                {0, -1, -1}};

            int result = challenge.CalculateCrosses(game);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void CalculateCrosses_EmptyGame_CalculatesCorrectCrosses()
        {
            int[,] game = {{-1, -1, -1},
                {-1, -1, -1},
                {-1, -1, -1}};

            int result = challenge.CalculateCrosses(game);
            Assert.AreEqual(0, result);
        }

    }      // Testing calculateMoves

    [TestClass]
    public class Test_CalculateMoves {

        private Challenge challenge;

        [TestInitialize]
        public void SetUp()
        {
            challenge = new Challenge();
        }

        [TestMethod]
        public void ValidGame_CalculatesCorrectMoveCount()
        {
            int[,] game = {{0, 1, -1},
                {0, 1, -1},
                {0, -1, -1}};

            int result = challenge.CalculateMoves(game);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void EmptyGame_CalculatesCorrectMoveCount()
        {
            int[,] game2 = {{-1, -1, -1},
                {-1, -1, -1},
                {-1, -1, -1}};
            int result2 = challenge.CalculateMoves(game2);
            Assert.AreEqual(0, result2);
        }
    }
    // Testing calculateMovesPercentage

    [TestClass]
    public class Test_CalculateMovesPercentage {

        private Challenge challenge;

        [TestInitialize]
        public void SetUp()
        {
            challenge = new Challenge();
        }

        [TestMethod]
        public void ValidGame_Returns33Percent()
        {
            int[,] game = {{0, -1, -1},
                {0, -1, -1},
                {1, -1, -1}};

            int result = challenge.CalculateMovesPercentage(game);
            Assert.AreEqual(33, result);
        }

        [TestMethod]
        public void EmptyGame_Returns0Percent()
        {
            int[,] game = {{-1, -1, -1},
                {-1, -1, -1},
                {-1, -1, -1}};

            int result = challenge.CalculateMovesPercentage(game);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void FullGame_Returns100Percent()
        {
            int[,] game = {{1, 0, 1},
                {1, 1, 0},
                {0, 1, 0}};

            int result = challenge.CalculateMovesPercentage(game);
            Assert.AreEqual(100, result);
        }
    }
    // -------------- INTERMEDIATE --------------

    // Testing hasPlayerWonHorizontal
    [TestClass]
    public class Test_HasPlayerWonHorizontal {

        private Challenge challenge;

        [TestInitialize]
        public void SetUp()
        {
            challenge = new Challenge();
        }

        [TestMethod]
        public void ValidWinNought_ReturnsTrue()
        {
            int[,] game = {{0, 1, 0},
                {0, 0, 0},
                {1, 1, 1}};

            bool result = challenge.HasPlayerWonHorizontal(game, 0);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidWinCross_ReturnsTrue()
        {
            int[,] game = {{0, 1, 0},
                {0, 1, 0},
                {1, 1, 1}};

            bool result = challenge.HasPlayerWonHorizontal(game, 1);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void InvalidWinNoughts_ReturnsFalse()
        {
            int[,] game = {{0, 0, 1},
                {0, 1, 0},
                {0, 1, 0}};

            bool result = challenge.HasPlayerWonHorizontal(game, 0);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void InvalidWinCrosses_ReturnsFalse()
        {
            int[,] game = {{0, 0, 1},
                {0, 1, 0},
                {0, 1, 0}};

            bool result = challenge.HasPlayerWonHorizontal(game, 1);
            Assert.IsFalse(result);
        }
    }

    [TestClass]
    public class Test_HasPlayerWonVertical {

        private Challenge challenge;

        [TestInitialize]
        public void SetUp()
        {
            challenge = new Challenge();
        }

        [TestMethod]
        public void ValidWinNoughts_ReturnsTrue()
        {
            int[,] game = {{0, 1, 0},
                {0, 0, 1},
                {0, 1, 0}};

            bool result = challenge.HasPlayerWonVertical(game, 0);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidWinCrosses_ReturnsTrue()
        {
            int[,] game = {{0, 1, 0},
                {1, 1, 0},
                {0, 1, 0}};

            bool result = challenge.HasPlayerWonVertical(game, 1);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void InvalidWinCrosses_ReturnsFalse()
        {
            int[,] game = {{0, 0, 1},
                {0, 1, 0},
                {1, 1, 0}};

            bool result = challenge.HasPlayerWonVertical(game, 1);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void InvalidWinNoughts_ReturnsFalse()
        {
            int[,] game = {{0, 0, 1},
                {0, 1, 0},
                {1, 1, 0}};

            bool result = challenge.HasPlayerWonVertical(game, 0);
            Assert.IsFalse(result);
        }
    }
    // Testing hasPlayerWonDiagonally
    [TestClass]
    public class Test_HasPlayerWonDiagonally {


        private Challenge challenge;

        [TestInitialize]
        public void SetUp()
        {
            challenge = new Challenge();
        }


        [TestMethod]
        public void ValidWinNoughts_ReturnsTrue()
        {
            int[,] leftDiagonalWin = {{0, 1, 0},
                {0, 0, 1},
                {1, 1, 0}};

            bool resultOne = challenge.HasPlayerWonDiagonally(leftDiagonalWin, 0);
            Assert.IsTrue(resultOne);

            int[,] rightDiagonalWin = {{0, 1, 0},
                {0, 0, 1},
                {0, 1, 1}};

            bool resultTwo = challenge.HasPlayerWonDiagonally(rightDiagonalWin, 0);
            Assert.IsTrue(resultTwo);
        }

        [TestMethod]
        public void ValidWinCrosses_ReturnsTrue()
        {
            int[,] leftDiagonalWin = {{1, 1, 0},
                {0, 1, 1},
                {0, 0, 1}};

            bool resultOne = challenge.HasPlayerWonDiagonally(leftDiagonalWin, 1);
            Assert.IsTrue(resultOne);

            int[,] rightDiagonalWin = {{1, 1, 0},
                {0, 1, 0},
                {0, 1, 1}};

            bool resultTwo = challenge.HasPlayerWonDiagonally(rightDiagonalWin, 1);
            Assert.IsTrue(resultTwo);
        }

        [TestMethod]
        public void InvalidWinCrosses_ReturnsFalse()
        {
            int[,] game = {{1, 1, 0},
                {0, 0, 1},
                {1, 0, 1}};

            bool result = challenge.HasPlayerWonDiagonally(game, 1);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void InvalidWinNoughts_ReturnsFalse()
        {
            int[,] game = {{0, 1, 0},
                {1, 0, 1},
                {1, 0, 1}};

            bool result = challenge.HasPlayerWonDiagonally(game, 0);
            Assert.IsFalse(result);
        }
    }
}

