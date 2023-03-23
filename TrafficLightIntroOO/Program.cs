using TrafficLightIntroOO;

/*
 * Unngå ugyldige tilstander
 * Innkapsling
    1: private objektvariabler
    2: public prop med private set
 * Constructor
 * Properties
 */

var trafficLight = new TrafficLight();
while (true)
{
    trafficLight.Show();
    Console.ReadKey();
    trafficLight.Next();
}


