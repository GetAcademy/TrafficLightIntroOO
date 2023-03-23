using TrafficLightIntroOO;

/*
 * Unngå ugyldige tilstander
 * Innkapsling
    1: private objektvariabler
    2: public prop med private set
 * Constructor
 * Properties
 
  Pause til 13:33
 
 */

var trafficLight = new TrafficLight();
trafficLight.Show();
Console.ReadKey();
trafficLight.Next();
trafficLight.Show();
Console.ReadKey();
trafficLight.Next();
trafficLight.Show();

//var isRed = trafficLight.GetIsRed();
//trafficLight.SetIsRed(false);
var isRed = trafficLight.IsRed;
//trafficLight.Interest = 5.3f;


Console.ReadKey();
trafficLight.Next();
trafficLight.Show();
Console.ReadKey();
trafficLight.Next();
trafficLight.Show();
//TrafficLightConsole.Show(true, false, true);

