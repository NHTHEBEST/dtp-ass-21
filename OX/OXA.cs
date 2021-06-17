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
        public static bool InetrTurn { get; set; };
        public static bool WaitForWinnerFill { get; set; } = true;
        
        readonly (int t1, int t2, int t3)[] WinCombos =
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
        public static OXGAME[] games;
        

        public OXA()
        {
            InitializeComponent();
            games = new OXGAME[] { oxgame1, oxgame2, oxgame6, oxgame3, oxgame4, oxgame5, oxgame7, oxgame8, oxgame9 };


        }
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

        void setState(Players winner)
        {
            foreach (var item in games)
            {
                item.setState(winner);
            }
            Refresh();
        }
        Players Winner
        {
            get
            {
                foreach (var wc in WinCombos)
                {
                    Players t1 = State[wc.t1 - 1];
                    Players t2 = State[wc.t2 - 1];
                    Players t3 = State[wc.t3 - 1];
                    if (t1 == Players.Nobody)
                    {
                        continue;
                    }
                    if (t1 == t2 && t2 == t3 && t1 == t3)
                    {
                        return t1;
                    }
                }
                return Players.Nobody;
            }
        }

        public static void SetTurn(Players _turn)
        {

            foreach (var x in games)
            {
                x.Turn = _turn;
            }
        }

        public void AlternativeClick()
        {
            if (Winner != Players.Nobody)
            {
                setState(Winner);
            }
        }

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
