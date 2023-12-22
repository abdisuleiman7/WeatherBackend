namespace Weather.Api.Core;

public class WeatherInfo
{
    public Coord Coord { get; set; }
    public List<CurrentWeather> Weather { get; set; }
    public string Base { get; set; }
    public MainInfo Main { get; set; }
    public Wind Wind { get; set; }
    public Clouds Clouds { get; set; }
    
}

public class Clouds
{
    public int all { get; set; }
}

public class Wind
{
    public double speed { get; set; }
    public int deg { get; set; }
    public double gust { get; set; }
}

public class MainInfo
{
    public double temp { get; set; }
    public double feels_like { get; set; }
    public double temp_min { get; set; }
    public double temp_max { get; set; }
    public int pressure { get; set; }
    public int humidity { get; set;}
    public int sea_level { get; set; }
    public int grnd_level { get; set; }
}

public class CurrentWeather
{
    public int id { get; set; }
    public string main { get; set; }
    public string description { get; set; }
    public string icon { get; set; }
}

public class Coord
{
    public float lon { get; set; }
    public float lat { get; set; }
}

