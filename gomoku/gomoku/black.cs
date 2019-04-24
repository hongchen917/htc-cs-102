using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gomoku
{
    class black : piece
    {
        public black(int x, int y) : base(x, y)
        {
            //black piece
            this.Image = Properties.Resources.black;
        }
        public override piecetype getpiecetype()
        {
            return piecetype.BLACK;
        }
    }
}
