using System.Text;

namespace TrafficLightIntroOO
{
    internal class TrafficLight
    {
        private int _phase;

        public bool IsRed => _phase is 0 or 1;
        //public bool IsRed => _phase < 2;
        //public bool IsRed => _phase == 0 || _phase == 1;
        public bool IsYellow => _phase is 1 or 3;
        //public bool IsYellow => _phase % 2 == 1;
        public bool IsGreen => _phase == 2;

        public TrafficLight()
        {
            _phase = 0;
        }

        public void Next()
        {
            _phase++;
            if (_phase == 4) _phase = 0;

            //_phase = (_phase + 1) % 4;

            //if (IsRed && !IsYellow && !IsGreen)
            //{
            //    IsYellow = true;
            //}
            //else if (IsRed && IsYellow && !IsGreen)
            //{
            //    IsRed = false;
            //    IsYellow = false;
            //    IsGreen = true;
            //}
            //else if (IsGreen)
            //{
            //    IsYellow = true;
            //    IsGreen = false;
            //}
            //else
            //{
            //    IsRed = true;
            //    IsYellow = false;
            //}
        }

        public void Show()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("┏━┓");
            DrawLine(IsRed ? ConsoleColor.Red : ConsoleColor.Black);
            DrawLine(IsYellow ? ConsoleColor.Yellow : ConsoleColor.Black);
            DrawLine(IsGreen ? ConsoleColor.Green : ConsoleColor.Black);
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
