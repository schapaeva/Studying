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
            Console.Write("\nEnter number of the columns: ");
            int columns = Int32.Parse(Console.ReadLine());
            Keyboard keyboard = new Keyboard(columns);
            keyboard.PrintKeyboard();
            Console.Write("\nEnter the movie name: ");
            string movieName = Console.ReadLine();
            Console.WriteLine(ReturnMoviePath(keyboard, movieName));
            Console.ReadKey();
        }

        public static string ReturnMoviePath(Keyboard keyboard, string movieName)
        {
            string moviePath = "";
            if (movieName.Length > 0)
            {
                moviePath += PathBetweenLetters(keyboard, 'a', movieName[0]);
                for (int i = 0; i < movieName.Length - 1; i++)
                {
                    moviePath += PathBetweenLetters(keyboard, movieName[i], movieName[i+1]);
                }
            }
            return moviePath;
        }

        public static string PathBetweenLetters(Keyboard keyboard, char start, char end)
        {
            string path = "";
            Button startButton = keyboard.GetButtonByChar(start);
            Button endButton = keyboard.GetButtonByChar(end);
            int diffX = startButton.X - endButton.X;
            int diffY = startButton.Y - endButton.Y;

            //Check if same letter, then return "E" for "Enter"
            if (diffX == 0 && diffY == 0) return "E";

            while(startButton.X != endButton.X || startButton.Y != endButton.Y)
            {
                startButton = GoHorizontal(keyboard, ref diffY, startButton, ref path);
                startButton = GoVertical(keyboard, ref diffX, startButton, ref path);
            }        
            path += "E";
            return path;
        }

        public static Button GoHorizontal(Keyboard keyboard, ref int diffY, Button startButton, ref string path)
        {
            if (diffY == 0) return startButton;
            string direction = (diffY < 0) ? "R" : "L";
            int step = (diffY < 0) ? 1 : -1;

            for (int i = 1; i <= Math.Abs(diffY); i++)
            {
                if (keyboard.GetButtonByCoordinates(startButton.X, (startButton.Y + step * i)).IfAvailable)
                    path += direction;
                else
                {
                    diffY += step * (i - 1);
                    return keyboard.GetButtonByCoordinates(startButton.X, startButton.Y + step * (i - 1));
                }
            }

            return keyboard.GetButtonByCoordinates(startButton.X, startButton.Y - diffY);
        }

        public static Button GoVertical(Keyboard keyboard, ref int diffX, Button startButton, ref string path)
        {
            if (diffX == 0) return startButton;
            string direction = (diffX < 0) ? "D" : "U";
            int step = (diffX < 0) ? 1 : -1;

            for (int i = 1; i <= Math.Abs(diffX); i++)
            {
                if (keyboard.GetButtonByCoordinates(startButton.X + step * i, startButton.Y).IfAvailable)
                    path += direction;
                else
                {
                    diffX += step * (i - 1);
                    return keyboard.GetButtonByCoordinates(startButton.X + step * (i - 1), startButton.Y); 
                }
            }

            return keyboard.GetButtonByCoordinates(startButton.X - diffX, startButton.Y);
        }
    }

    public class Keyboard
    {
        private int _columns;
        private int _rows;
        private Dictionary<char, Button> keysDict;

        public int Columns
        {
            get { return _columns; }
        }

        public int Rows
        {
            get { return _rows; }
        }

        public Keyboard(int columns)
        {
            //setting up columns
            if (columns > 0 && columns < 27)
            {
                _columns = columns;
            }
            else
                throw new Exception("You can't create keyboard with " + columns.ToString() + " columns.");

            //setting up rows
            if (26 % columns == 0)
                _rows = 26 / columns;
            else
                _rows = 26 / columns + 1;

            //setting up Buttons and populating the Dictionary
            keysDict = new Dictionary<char, Button>();
            char letter = '`';
            int count = 0;

            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    count++;
                    letter = (char)(letter + 1);
                    if (count <= 26)
                    {
                        Button button = new Button(i, j, letter, true);
                        AddButtonToDictionary(letter, button);
                    }
                    else
                    {
                        Button button = new Button(i, j, false);
                        AddButtonToDictionary(letter, button);
                    }           
                }
            }
        }

        //method Add Button to the dictionary
        private void AddButtonToDictionary(char ch, Button button)
        {
            if (!keysDict.ContainsKey(ch))
                keysDict.Add(ch, button);
        }

        //method Get Button by char
        public Button GetButtonByChar(char ch)
        {
            if (keysDict.ContainsKey(ch))
                return keysDict[ch];
            throw new Exception("No such button on the keyboard.");
        }
        public Button GetButtonByCoordinates(int x, int y)
        {
            foreach(KeyValuePair<char, Button> pair in keysDict)
            {
                if (pair.Value.X == x && pair.Value.Y == y) return pair.Value;
            }
            throw new Exception("There is no button by these coordinates.");
        }

        //method to Print the Keyboard 
        public void PrintKeyboard()
        {
            for(int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    Console.Write(GetButtonByCoordinates(i, j).Letter.ToString() + " ");
                }
                Console.Write("\n");
            }
        }
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
        public Button(int _x, int _y, bool _available)
        {
            x = _x;
            y = _y;
            letter = '\0';
            available = _available;
        }
    }
}
