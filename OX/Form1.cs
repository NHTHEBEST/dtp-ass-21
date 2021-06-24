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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Players tmp = Players.Nobody;
        private void tile1_Click(object sender, EventArgs e)
        {
            switch (tmp)
            {
                case Players.Nobody:
                    tmp = Players.Player1;
                    break;
                case Players.Player1:
                    tmp = Players.Player2;
                    break;
                case Players.Player2:
                    tmp = Players.Nobody;
                    break;
                default:
                    break;
            }
            tile1.OnClick(tmp);
        }
    }
}
