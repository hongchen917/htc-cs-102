using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gomoku
{
    class white : piece
    {
        public white(int x, int y) : base(x, y)
        {
            //white piece
            this.Image = Properties.Resources.white;
        }
        public override piecetype getpiecetype()
        {
            return piecetype.WHITE;
        }
    }
}
