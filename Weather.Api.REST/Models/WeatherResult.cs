using Weather.Api.Core;

public class WeatherResult{

public MainInfo Main { get; set; }


public  Task<WeatherResult> WeatherMapping(Task<WeatherInfo> input){
            WeatherResult weatherResult = new WeatherResult{
        Main = new MainInfo{
            temp = input.Result.Main.temp,
            feels_like = input.Result.Main.feels_like,
            temp_min = input.Result.Main.temp_min,
            temp_max = input.Result.Main.temp_max,
            pressure = input.Result.Main.pressure,
            humidity = input.Result.Main.humidity
        }
            };

    return Task.FromResult(weatherResult);

}
public class MainInfo
{
    public double temp { get; set; }
    public double feels_like { get; set; }
    public double temp_min { get; set; }
    public double temp_max { get; set; }
    public int pressure { get; set; }
    public int humidity { get; set;}
}
}


