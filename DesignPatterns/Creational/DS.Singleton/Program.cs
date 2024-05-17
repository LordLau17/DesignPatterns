using DS.Singleton;

var airplane = Airplane.GetInstance();
Console.WriteLine(airplane.GetAirplaneName());

var airplaneSecond = Airplane.GetInstance();
Console.WriteLine(airplaneSecond.GetAirplaneName());