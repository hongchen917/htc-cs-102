using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gomoku
{
    public partial class Form1 : Form
    {
        private game game = new game();
        private bool finish = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (finish == false)
            {
                piece piece = game.placeapiece(e.X, e.Y);
                if (piece != null)
                {
                    this.Controls.Add(piece);
                    //check anyone win?
                    if (game.fwinner == piecetype.BLACK)
                    {
                        MessageBox.Show( BlackPlayer_Name + " win");
                        finish = true;
                    }
                    else if (game.fwinner == piecetype.WHITE)
                    {
                        
                        MessageBox.Show( WhitePlayer_Name.Text + " win");
                        finish = true;
                    }
                }
            }
        }

/// ////////////////////////////////////////////////////////////////////////

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (finish == true)
            {
                this.Cursor = Cursors.No;
            }
            else
            {
                if (game.canplaced(e.X, e.Y))
                {
                    this.Cursor = Cursors.Hand;
                }
                else
                {
                    this.Cursor = Cursors.Default;
                }
            }

        }

        private void restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
