using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardAndMovieName
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Keyboard
    {
        private int columns;
        private Dictionary<char, Button> keys;

        public 
    }

    public class Button
    {
        private char letter;
        private int x;
        private int y;
        private bool available;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public bool IfAvailable
        {
            get { return available == true; }
            set { available = value; }
        }

        public char Letter
        {
            get { return letter; }
            set { letter = value; }
        }
       
        public Button(int _x, int _y, char _letter, bool _available)
        {
            x = _x;
            y = _y;
            letter = _letter;
            available = _available;
        }
    }
}
