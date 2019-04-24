using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace gomoku
{
    class board
    {
        public static readonly int count = 9;
        private static readonly int offset = 75;
        private static readonly int node_R = 10;
        private static readonly int node_dis = 75;
        private static readonly Point no_match = new Point(-1, -1);
        public static piece[,] pieces = new piece[count, count];
        private Point lastone = no_match;
        /// ////////////////////////////////////////////////////////////////////////////////

        public Point lastplace{ get { return lastone; } }
        public piecetype gettype(int nodeidx, int nodeidy)
        {
            if (pieces[nodeidx, nodeidy] == null)
            {
                return piecetype.NONE;
            }
            else
            {
                return pieces[nodeidx,nodeidy].getpiecetype();
            }
        }

        public bool canplace(int x, int y)
        {
            //find cloest 2 points
            Point nodeid = Findnode(x, y);
            //if not return false
            if (nodeid == no_match)
            {
                return false;
            }
            //if have check piece placed
            if (pieces[nodeid.X, nodeid.Y] != null)
            {
                return false;
            }
 
            return true;
        }

        /// ////////////////////////////////////////////////////////

        private Point Findnode(int x, int y)
        {
            int nodeidx = findclosetnode(x);
            if (nodeidx == -1 || nodeidx >= count)
            {
                return no_match;
            }
            int nodeidy = findclosetnode(y);
            if (nodeidy == -1 || nodeidx >= count)
            {
                return no_match;
            }
            return new Point(nodeidx , nodeidy);
        }
/// ////////////////////////////////////////////////////////////////////////////////////////

        private int findclosetnode(int pos)
        {
            if (pos < offset - node_R)
            {
                return -1;
            }
            pos -= offset;
            int quotient = pos / node_dis;
            int remaineder = pos % node_dis;

            if (remaineder <= node_R)
            {
                return quotient;
            }
            else if (remaineder >= node_dis - node_R)
            {
                return quotient + 1;
            }
            else
            {
                return -1;
            }
        }

   /// /////////////////////////////////////////////////////////////////////////////////////////

        public piece placeapiece(int x, int y, piecetype type)
        {
            //find cloest 2 points
            Point nodeid = Findnode(x, y);
            //if not return false
            if (nodeid == no_match)
            {
                return null;
            }
            //if have check piece placed
            if (pieces[nodeid.X, nodeid.Y] != null)
            {
                return null;
            }
            //make a piece by type
            Point formpos = convert(nodeid);
            if (type == piecetype.BLACK)
            {
                pieces[nodeid.X, nodeid.Y] = new black(formpos.X, formpos.Y);
            }
            else if (type == piecetype.WHITE)
            {
                pieces[nodeid.X, nodeid.Y] = new white(formpos.X, formpos.Y);
            }

            //final postion placed peice
            lastone = nodeid;
            return pieces[nodeid.X, nodeid.Y];
        }

   /// //////////////////////////////////////////////////////////////////////////////

        private Point convert(Point node)// correct postion of piece
        {
            Point form = new Point();
            form.X = node.X * node_dis + offset;
            form.Y = node.Y * node_dis + offset;
            return form;
        }

    }
}
