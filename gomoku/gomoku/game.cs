using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace gomoku
{
    class game
    { 
        // properties
        private board board = new board();
        private piecetype current = piecetype.BLACK;
        private piecetype winner = piecetype.NONE;
        public piecetype reset = piecetype.NONE;

        /// //////////////////////////////////

        public piecetype fwinner
        {
            get 
            {
                return winner;
            }
            set
            {
                if (value == current)
                {
                    winner = piecetype.NONE;
                    reset = piecetype.NONE;
                }
            } 
        } 
        ////////////////////////////////////////////////////////////////////////////
        public bool canplaced(int x, int y)
        {
            return board.canplace(x, y);
        }
   /////////////////////////////////////////////////////////////////////////////////
        
        public piece placeapiece(int x, int y)
        {
            piece piece = board.placeapiece(x, y, current);
            if (piece != null)
            {
                //check have winner rightnow?
                checkwin();
                //switch player
                if (current == piecetype.BLACK)
                {
                    current = piecetype.WHITE;
                }
                else if (current == piecetype.WHITE)
                {
                    current = piecetype.BLACK;
                }
                return piece;
            }
            return null;
        }
        //////////////////////////////////////////////////////////////////////////////////////////////
        private void checkwin()
        {
            int centerX = board.lastplace.X;
            int centerY = board.lastplace.Y;
            for (int xdir = -1; xdir <= 1; xdir++)
            {

                for (int ydir = -1; ydir <= 1; ydir++)
                {
                    int count2 = 1;
                    while (count2 < 5)
                    {
                        int targetx = centerX - count2 * xdir;
                        int targety = centerY - count2 * ydir;

                        if (targetx < 0 || targetx >= board.count ||
                            targety < 0 || targety >= board.count ||
                            board.gettype(targetx, targety) != current)
                        {
                            break;
                        }
                        count2++;
                        // without center x+0,y+0 if x+0 and y+0 skip
                        if (xdir == 0 && ydir == 0)
                        {
                            continue;
                        }
                        int count = 1;
                        ///////////store how many pieces right now
                        while (count < 5)
                        {
                            int x = count * xdir;
                            int y = count * ydir;
                            targetx = centerX + x;
                            targety = centerY + y;
                            // check is color the same
                            if (targetx < 0 || targetx >= board.count ||
                                targety < 0 || targety >= board.count ||
                                board.gettype(targetx, targety) != current)
                            {

                                break;
                            }
                            count++;
                        }
                        //check
                        if (count == 5)
                        {
                            winner = current;
                        }
                        if (count + count2 > 5)
                        {
                            winner = current;
                            reset = current;
                        }
                    }
                }
            }
        }
        /// ////////////////////////////////////////////////////////////
        /// 


     }
}
