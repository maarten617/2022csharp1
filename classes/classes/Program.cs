using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace classes
{

    internal class Program
    {
        static void Main()
        {
           rectangle joe = new rectangle();
            joe.x = 100;
            joe.y = 200;
            joe.width= 50;
            joe.height= 50;
        }
    }
    public class rectangle
    {
        public int x;
        public int y;
        public int width;
        public int height;
    }

}