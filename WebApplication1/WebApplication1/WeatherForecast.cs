using System;

namespace WebApplication1
{
    /// <summary>
    /// Added comment
    /// </summary>
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        /// <summary>
        /// Is this correct
        /// </summary>
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        /// <summary>
        /// Excellent
        /// </summary>
        public string Summary { get; set; }
    }
}
