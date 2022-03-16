using System;
namespace Challenges.c5_arrays_extended
{
    public class Challenge
    {

        ///
        ///  All of the challenges in the this folder are focused on working with a multidimensional array / nested array.
        /// This is to mimic the grid of a noughts and crosses game. That is why we are using this data structure.
        ///
        /// KEY
        /// - -1 = (No Move)
        /// - 0 = (Naught)
        /// - 1 = (Cross)
        ///
        /// EXAMPLE
        ///  int[][] game = {{1, 1, 0},
        ///                  {1, 0, 1},
        ///                 {-1, 0, -1}}
        ///
        /// HINT: You may have to use a nested for loop to loop through the nested array.

        // -------------- FOUNDATION --------------

        /// <summary></summary>
        ///     Calculate how many crosses are in the given game
        /// </summary>
        /// 
        /// <param name="game"> - Two Dimensional arrays contains -1 (No Move), 0 (Naught), 1 (Cross) </param>
        /// <returns> count of all the Crosses (1's) in the given game </returns>
        public int CalculateCrosses(int[,] game)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Calculate how many moves (noughts and crosses) are in the given game.
        /// </summary>
        ///
        /// <param name="game"> Two Dimensional arrays contains -1 (No Move), 0 (Naught), 1 (Cross) </param>
        /// <returns> count of the noughts (0's) and crosses (1's) in the given game </returns>
        public int CalculateMoves(int[,] game)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Calculate percentage of used squares in the given game.
        /// </summary>
        ///
        /// <param name="game"> Two Dimensional arrays contains -1 (No Move), 0 (Naught), 1 (Cross) </param>
        /// <returns> float the percentage of used squares </returns>
        public float CalculateMovesPercentage(int[,] game)
        {
            throw new NotImplementedException();
        }

        // -------------- INTERMEDIATE --------------


        /**
         * Checks if the given player has won "horizontally" in the given game.
         *
         * Don't check for vertical or diagonal wins just yet
         *
         * @param game - Two Dimensional arrays contains -1 (No Move), 0 (Naught), 1 (Cross)
         * @param player - 0 (Naught) or 1 (cross)
         * @return If the given player has horizontally won or not
         */

        /// <summary>
        ///     Checks if the given player has won "horizontally" in the given game.
        ///     Don't check for vertical or diagonal wins just yet
        /// </summary>
        ///
        /// <param name="game"> Two Dimensional arrays contains -1 (No Move), 0 (Naught), 1 (Cross) </param>
        /// <param name="player"> - 0 (Naught) or 1 (cross) </param>
        /// <returns> If the given player has horizontally won or not </returns>
        public bool HasPlayerWonHorizontal(int[,] game, int player)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Checks if the given player has won "vertically" in the given game.
        ///     Don't check for diagonal wins just yet
        /// </summary>
        ///
        /// <param name="game"> Two Dimensional arrays contains -1 (No Move), 0 (Naught), 1 (Cross) </param>
        /// <param name="player"> - 0 (Naught) or 1 (cross) </param>
        /// <returns> If the given player has vertically won or not </returns>
        public bool HasPlayerWonVertical(int[,] game, int player)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Checks if the given player has won "diagonally" in the given game.
        /// </summary>
        ///
        /// <param name="game"> Two Dimensional arrays contains -1 (No Move), 0 (Naught), 1 (Cross) </param>
        /// <param name="player"> - 0 (Naught) or 1 (cross) </param>
        /// <returns> If the given player has diagonally won or not </returns>
        public bool HasPlayerWonDiagonally(int[,] game, int player)
        {
            throw new NotImplementedException();
        }

        // -------------- ADVANCED --------------

        /// <summary>
        ///     Checks if any player has won the game, and returns the player which won
        /// </summary>
        ///
        /// <param name="game"> Two Dimensional arrays contains -1 (No Move), 0 (Naught), 1 (Cross) </param>
        /// <returns> The player that won, or -1 if no winner </returns>
        public int GetWinningPlayer(int[,] game)
        {
            // ..... Who can solve this? ;)
            throw new NotImplementedException();
        }
    }
}
