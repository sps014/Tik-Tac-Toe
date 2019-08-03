using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TIK_TAC_TOE.TileSpot;

namespace TIK_TAC_TOE
{
    public static class GameManager
    {
        public static int Turn { get; set; } = 0;

        public static void OnSpotClicked(TileSpot tileSpot)
        {
            if (WinnerChecker.CheckWin(BlackBoard.Spots) == GameResult.GAME_ON)
            {
                if (tileSpot.Owner == OwnerType.NONE)
                {
                    if (Turn % 2 == 0)
                    {
                        tileSpot.Owner = OwnerType.PLAYER;
                        Turn++;
                    }
                    
                    if(WinnerChecker.CheckWin(BlackBoard.Spots)==GameResult.GAME_ON && Turn<=7)
                    {
                        var bestMove = BrainAI.GetBestMoveAI(BlackBoard.Spots);

                        if (BlackBoard.Spots[bestMove.I, bestMove.J].Owner == OwnerType.NONE)
                            BlackBoard.Spots[bestMove.I, bestMove.J].Owner = OwnerType.AI;
                    }

                    if (Turn < 9)
                        Turn++;
                }
            }
            switch(WinnerChecker.CheckWin(BlackBoard.Spots))
            {
                case GameResult.AI_WIN:
                    MessageBox.Show("AI Won");
                    break;
                case GameResult.PLAYER_WIN:
                    MessageBox.Show("Player Won");
                    break;
                case GameResult.GAME_DRAW:
                    MessageBox.Show("Draw");
                    break;
            }
        }

        public static void Restart()
        {
            Turn = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    BlackBoard.Spots[i, j].Owner = OwnerType.NONE;
                }
            }
        }
    }
}
