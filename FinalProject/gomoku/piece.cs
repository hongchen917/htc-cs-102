using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace gomoku
{
    abstract class piece : PictureBox
    {
        private static readonly int IM_width = 50;
        public piece(int x, int y)
        {
            //make a piece
            this.BackColor = Color.Transparent;
            this.Location = new Point(x - IM_width/2, y - IM_width/2);
            this.Size = new Size(50, 50);
        }
        public abstract piecetype getpiecetype();
    }
}
