using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            MiscsFunctions miscs = new MiscsFunctions();
            bool displayMenue = true;
            while (displayMenue)
            {
                displayMenue = miscs.MainMenue();
            }
        }
    }
}
