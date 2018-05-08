using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekenmachine
{
    public class Output
    {
        public static void Message(Request req)
        {
            Console.WriteLine("Left: {0}", req.LeftHand);
            Console.WriteLine("Right: {0}", req.RightHand);
            Console.WriteLine("Operation: {0}", req.Operation);
            Console.WriteLine("Result: {0}", req.Calculate());
        }
    }
}
