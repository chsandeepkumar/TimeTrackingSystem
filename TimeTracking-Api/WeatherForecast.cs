namespace TimeTracking_Api
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 22 + (int)(TemperatureC / 0.5556);
       
        public string? Summary { get; set; }
    }
}