using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Round
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This app initializes a round.");
            Round round = null;
            try
            {
                round = Round.InitRound();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            round?.Show();
            round.Radius = 5;
            round?.Show();

        }
     
    }
}
