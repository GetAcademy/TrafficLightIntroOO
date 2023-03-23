using System.Text;

namespace TrafficLightIntroOO
{
    internal class TrafficLight
    {
        private bool _isRed;
        private bool _isYellow;
        private bool _isGreen;

        public TrafficLight()
        {
            _isRed = true;
            _isYellow = false;
            _isGreen = false;
        }

        public void Next()
        {
            if (_isRed && !_isYellow && !_isGreen)
            {
                _isYellow = true;
            }
        }

        public void Show()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("┏━┓");
            DrawLine(_isRed ? ConsoleColor.Red : ConsoleColor.Black);
            DrawLine(_isYellow ? ConsoleColor.Yellow : ConsoleColor.Black);
            DrawLine(_isGreen ? ConsoleColor.Green : ConsoleColor.Black);
            Console.WriteLine("┗━┛");
        }

        private static void DrawLine(ConsoleColor color)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("┃");
            Console.ForegroundColor = color;
            Console.Write("O");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("┃");
        }
    }
}
