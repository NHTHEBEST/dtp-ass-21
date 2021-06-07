
namespace OX
{
    partial class OXGAME
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tile1 = new OX.Tile();
            this.tile5 = new OX.Tile();
            this.tile7 = new OX.Tile();
            this.tile4 = new OX.Tile();
            this.tile8 = new OX.Tile();
            this.tile9 = new OX.Tile();
            this.tile2 = new OX.Tile();
            this.tile3 = new OX.Tile();
            this.tile6 = new OX.Tile();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.tile1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tile5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tile7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tile4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tile8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tile9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tile2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tile3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tile6, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 461);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // tile1
            // 
            this.tile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tile1.Location = new System.Drawing.Point(3, 3);
            this.tile1.Name = "tile1";
            this.tile1.NextSet = OX.Players.Player1;
            this.tile1.NobodyDisabled = System.Drawing.Color.Gray;
            this.tile1.NobodyEnabled = System.Drawing.Color.White;
            this.tile1.Player1Disabled = System.Drawing.Color.DarkRed;
            this.tile1.Player1Enabled = System.Drawing.Color.Red;
            this.tile1.Player2Disabled = System.Drawing.Color.DarkBlue;
            this.tile1.Player2Enabled = System.Drawing.Color.Blue;
            this.tile1.Size = new System.Drawing.Size(147, 147);
            this.tile1.State = OX.Players.Nobody;
            this.tile1.TabIndex = 0;
            this.tile1.Click += new System.EventHandler(this.tile1_Click);
            // 
            // tile5
            // 
            this.tile5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tile5.Location = new System.Drawing.Point(156, 156);
            this.tile5.Name = "tile5";
            this.tile5.NextSet = OX.Players.Player1;
            this.tile5.NobodyDisabled = System.Drawing.Color.Gray;
            this.tile5.NobodyEnabled = System.Drawing.Color.White;
            this.tile5.Player1Disabled = System.Drawing.Color.DarkRed;
            this.tile5.Player1Enabled = System.Drawing.Color.Red;
            this.tile5.Player2Disabled = System.Drawing.Color.DarkBlue;
            this.tile5.Player2Enabled = System.Drawing.Color.Blue;
            this.tile5.Size = new System.Drawing.Size(147, 147);
            this.tile5.State = OX.Players.Nobody;
            this.tile5.TabIndex = 4;
            this.tile5.Click += new System.EventHandler(this.tile5_Click);
            // 
            // tile7
            // 
            this.tile7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tile7.Location = new System.Drawing.Point(3, 309);
            this.tile7.Name = "tile7";
            this.tile7.NextSet = OX.Players.Player1;
            this.tile7.NobodyDisabled = System.Drawing.Color.Gray;
            this.tile7.NobodyEnabled = System.Drawing.Color.White;
            this.tile7.Player1Disabled = System.Drawing.Color.DarkRed;
            this.tile7.Player1Enabled = System.Drawing.Color.Red;
            this.tile7.Player2Disabled = System.Drawing.Color.DarkBlue;
            this.tile7.Player2Enabled = System.Drawing.Color.Blue;
            this.tile7.Size = new System.Drawing.Size(147, 149);
            this.tile7.State = OX.Players.Nobody;
            this.tile7.TabIndex = 6;
            this.tile7.Enter += new System.EventHandler(this.tile7_Enter);
            // 
            // tile4
            // 
            this.tile4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tile4.Location = new System.Drawing.Point(3, 156);
            this.tile4.Name = "tile4";
            this.tile4.NextSet = OX.Players.Player1;
            this.tile4.NobodyDisabled = System.Drawing.Color.Gray;
            this.tile4.NobodyEnabled = System.Drawing.Color.White;
            this.tile4.Player1Disabled = System.Drawing.Color.DarkRed;
            this.tile4.Player1Enabled = System.Drawing.Color.Red;
            this.tile4.Player2Disabled = System.Drawing.Color.DarkBlue;
            this.tile4.Player2Enabled = System.Drawing.Color.Blue;
            this.tile4.Size = new System.Drawing.Size(147, 147);
            this.tile4.State = OX.Players.Nobody;
            this.tile4.TabIndex = 3;
            this.tile4.Click += new System.EventHandler(this.tile4_Click);
            // 
            // tile8
            // 
            this.tile8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tile8.Location = new System.Drawing.Point(156, 309);
            this.tile8.Name = "tile8";
            this.tile8.NextSet = OX.Players.Player1;
            this.tile8.NobodyDisabled = System.Drawing.Color.Gray;
            this.tile8.NobodyEnabled = System.Drawing.Color.White;
            this.tile8.Player1Disabled = System.Drawing.Color.DarkRed;
            this.tile8.Player1Enabled = System.Drawing.Color.Red;
            this.tile8.Player2Disabled = System.Drawing.Color.DarkBlue;
            this.tile8.Player2Enabled = System.Drawing.Color.Blue;
            this.tile8.Size = new System.Drawing.Size(147, 149);
            this.tile8.State = OX.Players.Nobody;
            this.tile8.TabIndex = 7;
            this.tile8.Click += new System.EventHandler(this.tile8_Click);
            // 
            // tile9
            // 
            this.tile9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tile9.Location = new System.Drawing.Point(309, 309);
            this.tile9.Name = "tile9";
            this.tile9.NextSet = OX.Players.Player1;
            this.tile9.NobodyDisabled = System.Drawing.Color.Gray;
            this.tile9.NobodyEnabled = System.Drawing.Color.White;
            this.tile9.Player1Disabled = System.Drawing.Color.DarkRed;
            this.tile9.Player1Enabled = System.Drawing.Color.Red;
            this.tile9.Player2Disabled = System.Drawing.Color.DarkBlue;
            this.tile9.Player2Enabled = System.Drawing.Color.Blue;
            this.tile9.Size = new System.Drawing.Size(148, 149);
            this.tile9.State = OX.Players.Nobody;
            this.tile9.TabIndex = 8;
            this.tile9.Click += new System.EventHandler(this.tile9_Click);
            // 
            // tile2
            // 
            this.tile2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tile2.Location = new System.Drawing.Point(156, 3);
            this.tile2.Name = "tile2";
            this.tile2.NextSet = OX.Players.Player1;
            this.tile2.NobodyDisabled = System.Drawing.Color.Gray;
            this.tile2.NobodyEnabled = System.Drawing.Color.White;
            this.tile2.Player1Disabled = System.Drawing.Color.DarkRed;
            this.tile2.Player1Enabled = System.Drawing.Color.Red;
            this.tile2.Player2Disabled = System.Drawing.Color.DarkBlue;
            this.tile2.Player2Enabled = System.Drawing.Color.Blue;
            this.tile2.Size = new System.Drawing.Size(147, 147);
            this.tile2.State = OX.Players.Nobody;
            this.tile2.TabIndex = 1;
            this.tile2.Click += new System.EventHandler(this.tile2_Click);
            // 
            // tile3
            // 
            this.tile3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tile3.Location = new System.Drawing.Point(309, 3);
            this.tile3.Name = "tile3";
            this.tile3.NextSet = OX.Players.Player1;
            this.tile3.NobodyDisabled = System.Drawing.Color.Gray;
            this.tile3.NobodyEnabled = System.Drawing.Color.White;
            this.tile3.Player1Disabled = System.Drawing.Color.DarkRed;
            this.tile3.Player1Enabled = System.Drawing.Color.Red;
            this.tile3.Player2Disabled = System.Drawing.Color.DarkBlue;
            this.tile3.Player2Enabled = System.Drawing.Color.Blue;
            this.tile3.Size = new System.Drawing.Size(148, 147);
            this.tile3.State = OX.Players.Nobody;
            this.tile3.TabIndex = 2;
            this.tile3.Click += new System.EventHandler(this.tile3_Click);
            // 
            // tile6
            // 
            this.tile6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tile6.Location = new System.Drawing.Point(309, 156);
            this.tile6.Name = "tile6";
            this.tile6.NextSet = OX.Players.Player1;
            this.tile6.NobodyDisabled = System.Drawing.Color.Gray;
            this.tile6.NobodyEnabled = System.Drawing.Color.White;
            this.tile6.Player1Disabled = System.Drawing.Color.DarkRed;
            this.tile6.Player1Enabled = System.Drawing.Color.Red;
            this.tile6.Player2Disabled = System.Drawing.Color.DarkBlue;
            this.tile6.Player2Enabled = System.Drawing.Color.Blue;
            this.tile6.Size = new System.Drawing.Size(148, 147);
            this.tile6.State = OX.Players.Nobody;
            this.tile6.TabIndex = 5;
            this.tile6.Click += new System.EventHandler(this.tile6_Click);
            // 
            // OXGAME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OXGAME";
            this.Size = new System.Drawing.Size(460, 461);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Tile tile1;
        private Tile tile2;
        private Tile tile3;
        private Tile tile4;
        private Tile tile5;
        private Tile tile6;
        private Tile tile7;
        private Tile tile8;
        private Tile tile9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
