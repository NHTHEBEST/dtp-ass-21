using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace OX
{
    public partial class OXA : UserControl
    {
        /// <summary>
        /// set to true if between turns
        /// </summary>
        public static bool InetrTurn = false;
        /// <summary>
        /// set to fales while filling in a winer square
        /// </summary>
        public static bool WaitForWinnerFill = true;
        /// <summary>
        /// all of the win combos
        /// </summary>
        (int t1, int t2, int t3)[] WinCombos =
        {
            (1,2,3),
            (4,5,6),
            (7,8,9),
            (1,4,7),
            (2,5,8),
            (3,6,9),
            (1,5,9),
            (3,5,7)
        };
        /// <summary>
        /// array of all internal 3x3 games
        /// </summary>
        public static OXGAME[] games;

        public OXA()
        {
            InitializeComponent();
            // fill in the games array
            games = new OXGAME[] { oxgame1, oxgame2, oxgame6, oxgame3, oxgame4, oxgame5, oxgame7, oxgame8, oxgame9 };


        }
        /// <summary>
        /// state of each 3x3 game
        /// </summary>
        public Players[] State
        {
            get
            {
                List<Players> states_ = new List<Players>();
                foreach (var x in games)
                    states_.Add(x.Winner);
                return states_.ToArray();
            }
        }
        /// <summary>
        /// sets the state of mingames
        /// </summary>
        /// <param name="winner">player to set the state to</param>
        void setState(Players winner)
        {
            foreach (var item in games)
            {
                item.setState(winner);
            }
            Refresh();
        }
        /// <summary>
        /// winner of 9x9 game
        /// </summary>
        Players Winner
        {
            get
            {
                // loop through each win combo
                foreach (var wc in WinCombos)
                {
                    Players t1 = State[wc.t1 - 1];
                    Players t2 = State[wc.t2 - 1];
                    Players t3 = State[wc.t3 - 1];
                    if (t1 == Players.Nobody)
                        continue;
                    if (t1 == t2 && t2 == t3 && t1 == t3)
                        return t1;
                }
                return Players.Nobody;
            }
        }
        /// <summary>
        /// sets the turn vaubals 
        /// </summary>
        /// <param name="_turn">the player to set the turn to</param>
        public static void SetTurn(Players _turn)
        {

            foreach (var x in games)
                x.Turn = _turn;
        }



        /// <summary>
        /// run on clickes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tile_Click(object sender, EventArgs e)
        {
            if (Winner != Players.Nobody)
            {
                setState(Winner);
                Refresh();
            }

            

        }

    }
}
