using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIK_TAC_TOE
{
    public static class WinnerChecker
    {
        public static GameResult CheckWin(OwnerType[,] board)
        {
            if (isWin(board, OwnerType.PLAYER))
            {
                return GameResult.PLAYER_WIN;
            }
            else if (isWin(board, OwnerType.AI))
            {
                return GameResult.AI_WIN;
            }
            else if(GameManager.Turn>=9)
            {
                return GameResult.GAME_DRAW;
            }
            else
            {
                return GameResult.GAME_ON;
            }
        }

        public static GameResult CheckWin(TileSpot[,] board)
        {
            var ownerTypes = TileSpotToOwnerType(board);
            return CheckWin(ownerTypes);
        }

        static OwnerType[,] TileSpotToOwnerType(TileSpot[,] board)
        {
            OwnerType[,] ownerTypes = new OwnerType[3, 3];
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    ownerTypes[i, j] = board[i, j].Owner;
                }
            }
            return ownerTypes;
        }

        private static bool isWin(OwnerType[,] board, OwnerType type)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == type && board[i, 1] == type && board[i, 2] == type)
                {
                    return true;
                }

                if (board[0,i] == type && board[1, i] == type && board[2,i] == type)
                {
                    return true;
                }
            }

            if (board[0, 0] == type && board[1, 1] == type && board[2, 2] == type)
            {
                return true;
            }
            if (board[2, 0] == type && board[1, 1] == type && board[0, 2] == type)
            {
                return true;
            }

            return false;
        }
        public static List<TileSpot> AvailableSpots(TileSpot[,] Spots)
        {
            List<TileSpot> tiles = new List<TileSpot>();
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    if (Spots[i, j].Owner == OwnerType.NONE)
                        tiles.Add(Spots[i, j]);
                }
            }

            return tiles;
        }
    }
}
