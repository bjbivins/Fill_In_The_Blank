using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Player // CREATE PLAYER CLASS
    {
        private bool X_or_O;
        public bool X_or_O1 { get => X_or_O; set => X_or_O = value; }

        public override string ToString()
        {
            if (X_or_O == true)
            {
                return "X"; // TRUE = X
            }

            else
            {
                return "O"; // FALSE = O
            }
        }
    }
}
