using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace OX
{
    public partial class OXGAME : UserControl
    {
        Tile[] Tiles;
        //public OXA oxa;

        public OXGAME()
        {
            InitializeComponent();
            Tiles = new Tile[]{ tile1, tile2, tile3, tile4, tile5, tile6, tile7, tile8, tile9};
            foreach (Tile x in Tiles)
                x.Click += Tile_Click;
            //oxa = (OXA)Parent;

        }
        public Players[] State 
        { 
            get 
            {
                Players[] r1 = { tile1.State, tile2.State, tile3.State };
                Players[] r2 = { tile4.State, tile5.State, tile6.State };
                Players[] r3 = { tile7.State, tile8.State, tile9.State };

                Players[][] s = { r1, r2, r3 };
                return new Players[]{ tile1.State, tile2.State, tile3.State,tile4.State, tile5.State, tile6.State,tile7.State, tile8.State, tile9.State};
            } 
        }
        public void setState(Players winner)
        {
            foreach (var item in Tiles)
            {
//                item.Clicked = true;
                item.State = Winner;
                item.Refresh();
            }
            
        }
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

        public Players Winner
        {
            get
            {
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

        private void Tile_Click(object sender, EventArgs e)
        {
            //OnClick(e);
            if (Enabled && !OXA.InetrTurn)
            {
                if (Winner != Players.Nobody)
                    setState(Winner);
                else
                {
                    if (!((Tile)sender).Clicked)
                    {
                        ((Tile)sender).OnClick(_turn);

                        switch (_turn)
                        {
                            case Players.Player1:
                                _turn = Players.Player2;
                                break;
                            case Players.Player2:
                                _turn = Players.Player1;
                                break;
                        }
                        OXA.SetTurn(_turn);
                    }
                    foreach (var item in Tiles)
                    {
                        //item.NextSet = _turn;
                        item.Refresh();
                    }
                }
                if (Winner != Players.Nobody)
                    foreach (var item in Tiles)
                    {
                        item.State = Winner;
                        item.Refresh();
                    }

                //oxa.AlternativeClick();
                OnClick(e);
                Refresh();
                OXA.WaitForWinnerFill = false;
            }
        }

        public Players _turn = Players.Player1;

        public Players Turn { get { return _turn; } set { _turn = value; foreach (var item in Tiles) item.NextSet = value; } }

        

        void changeActivs(int a)
        {
            if (!OXA.InetrTurn)
            {
                new Thread(() =>
                {
                    //Thread.Sleep(1000);
                    while (OXA.WaitForWinnerFill) ;
                    BeginInvoke((MethodInvoker)delegate
                    {
                        var winner = OXA.games[a].Winner;
                        if (winner == Players.Nobody)
                        {
                            foreach (var x in OXA.games)
                                x.Enabled = false;
                            OXA.games[a].Enabled = true;
                        }
                        else
                            foreach (var x in OXA.games)
                                x.Enabled = true;
                    });
                    OXA.InetrTurn = false;
                    OXA.WaitForWinnerFill = true;
                }).Start();
            }
        }

        private void tile1_Click(object sender, EventArgs e)
        {
            changeActivs(0);
        }
        private void tile2_Click(object sender, EventArgs e)
        {
            changeActivs(1);
        }

        private void tile3_Click(object sender, EventArgs e)
        {
            changeActivs(2);
        }

        private void tile4_Click(object sender, EventArgs e)
        {
            changeActivs(3);
        }

        private void tile5_Click(object sender, EventArgs e)
        {
            changeActivs(4);
        }

        private void tile6_Click(object sender, EventArgs e)
        {
            changeActivs(5);
        }

        private void tile7_Enter(object sender, EventArgs e)
        {
            changeActivs(6);
        }

        private void tile8_Click(object sender, EventArgs e)
        {
            changeActivs(7);
        }

        private void tile9_Click(object sender, EventArgs e)
        {
            changeActivs(8);
        }
    }
}
