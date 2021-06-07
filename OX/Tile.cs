using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OX
{
    public enum Players
    {
        Nobody = 0,
        Player1 = 1,
        Player2 = 2
    }

    public partial class Tile : UserControl
    {
       
        public Tile()
        {
            InitializeComponent();
            //Click += Tile_Click;
        }


        public bool Clicked = false;
        

        private void Tile_Click(object sender, EventArgs e)
        {
            if (!Clicked)
            {
                _state = NextSet;
                Clicked = true;
            }
            Refresh();
        }

        public void OnClick(Players player)
        {
            if (!Clicked)
            {                
                _state = player;
                Clicked = true;
            }
            Refresh();
        }

        public new int Width { get { return base.Height; } set { base.Height = value; } }
        public new int Height { get { return base.Height; } set { base.Height = value; } }

        public Players _state = Players.Nobody;
        public Color Player1Enabled { get; set; } = Color.Red;
        public Color Player2Enabled { get; set; } = Color.Blue;
        public Color NobodyEnabled { get; set; } = Color.White;
        public Color Player1Disabled { get; set; } = Color.DarkRed;
        public Color Player2Disabled { get; set; } = Color.DarkBlue;
        public Color NobodyDisabled { get; set; } = Color.Gray;

        
        public Players NextSet { get; set; } = Players.Player1;
        public Players State {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
                Refresh();
            } 
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            if (Enabled)
            switch (_state)
            {
                case Players.Nobody:
                    e.Graphics.Clear(NobodyEnabled);
                    break;
                case Players.Player1:
                    e.Graphics.Clear(Player1Enabled);
                    break;
                case Players.Player2:
                    e.Graphics.Clear(Player2Enabled);
                    break;
    
            }else
                switch (_state)
                {
                    case Players.Nobody:
                        e.Graphics.Clear(NobodyDisabled);
                        break;
                    case Players.Player1:
                        e.Graphics.Clear(Player1Disabled);
                        break;
                    case Players.Player2:
                        e.Graphics.Clear(Player2Disabled);
                        break;
                }

        }

      
    }
}
