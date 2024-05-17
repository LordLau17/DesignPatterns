namespace DS.Singleton;

internal class Airplane
{
    private static Airplane? _instance;

    private readonly string _name;

    private Airplane()
    {
        _name = $"Airplane_#{new Random().Next()}";
    }

    public static Airplane GetInstance()
    {
        _instance ??= new Airplane();
        return _instance;
    }

    public string GetAirplaneName()
    {
        return _name;
    }
}