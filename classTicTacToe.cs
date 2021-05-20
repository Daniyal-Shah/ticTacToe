using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class classTicTacToe
    {

        bool toggleValue = true;
        string userOne = "O";
        string userTwo = "X";

        public string GetUserTwo()
        {
            return userTwo;
        }

        public void SetUserTwo(string value)
        {
            userTwo = value;
        }

        public string GetUserOne()
        {
            return userOne;
        }

        public void SetUserOne(string value)
        {
            userOne = value;
        }

        public bool GetToggleValue()
        {
            return toggleValue;
        }

        public void SetToggleValue(bool value)
        {
            toggleValue = value;
        }
    }
}
