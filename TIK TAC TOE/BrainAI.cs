using System.Collections.Generic;

namespace TIK_TAC_TOE
{
    public struct AIMove
    {
        public int Score { get; set; }
        public int I { get; set; }
        public int J { get; set; }
        
    }
    public static class BrainAI
    {
        public static AIMove GetBestMoveAI(TileSpot[,] board)
        {
            return MiniMax(board,OwnerType.AI);
        }

        public static AIMove MiniMax(TileSpot[,] board, OwnerType player)
        {
            var AvailSpots = WinnerChecker.AvailableSpots(board);

            switch(WinnerChecker.CheckWin(board))
            {
                case GameResult.AI_WIN:
                    return new AIMove() { Score = 10 };
                case GameResult.PLAYER_WIN:
                    return new AIMove() { Score = -10 };
                case GameResult.GAME_DRAW:
                    return new AIMove() { Score = 0 };
            }
            List<AIMove> moves = new List<AIMove>();

            for(int i=0;i<AvailSpots.Count;i++)
            {
                AIMove move = new AIMove();
                move.I = AvailSpots[i].Uid2D.I;
                move.J = AvailSpots[i].Uid2D.J;

                AvailSpots[i].Owner = player;

                if(player==OwnerType.AI)
                {
                     move.Score = MiniMax(board, OwnerType.PLAYER).Score;
                }
                else
                {
                    move.Score = MiniMax(board, OwnerType.AI).Score;
                }

                moves.Add(move);


                AvailSpots[i].Owner = OwnerType.NONE;
            }

            int bestMove=0;

            if(player==OwnerType.AI)
            {
                int bestMax = -100000;
                for(int i=0;i<moves.Count;i++)
                {
                    if (moves[i].Score > bestMax)
                    {
                        bestMax = moves[i].Score;
                        bestMove=i;
                    }
                }
            }
            else
            {
                int bestMin = 100000;
                for (int i = 0; i < moves.Count; i++)
                {
                    if (moves[i].Score < bestMin)
                    {
                        bestMin = moves[i].Score;
                        bestMove = i;
                    }
                }
            }

            return bestMove<moves.Count?moves[bestMove]:new AIMove() {Score=0};
        }
    }
}
