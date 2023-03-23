namespace TrafficLightIntroOO
{
    internal class TextRepo
    {
        private static TextRepo _theInstance;

        private TextRepo()
        {

        }

        public static TextRepo GetInstance()
        {
            if (_theInstance == null) _theInstance = new TextRepo();
            return _theInstance;
        }
    }
}
