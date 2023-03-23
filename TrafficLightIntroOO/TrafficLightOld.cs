using System.Text;

namespace TrafficLightIntroOO
{
    internal class TrafficLightOld
    {
        public bool IsRed { get; private set; }
        public bool IsYellow { get; private set; }
        public bool IsGreen { get; private set; }

        public TrafficLightOld()
        {
            IsRed = true;
            IsYellow = false;
            IsGreen = false;
        }

        //private float _interest;
        //public float Interest
        //{
        //    get
        //    {

        //        return _interest;
        //    }
        //    set
        //    {
        //        _interest = value;
        //    }
        //}

        //public bool GetIsRed()
        //{
        //    return _isRed;
        //}

        //public void SetIsRed(bool value)
        //{
        //    _isRed = value;
        //}

        public void Next()
        {
            if (IsRed && !IsYellow && !IsGreen)
            {
                IsYellow = true;
            }
            else if (IsRed && IsYellow && !IsGreen)
            {
                IsRed = false;
                IsYellow = false;
                IsGreen = true;
            }
            else if (IsGreen)
            {
                IsYellow = true;
                IsGreen = false;
            }
            else
            {
                IsRed = true;
                IsYellow = false;
            }
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
