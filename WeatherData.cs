using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_App
{

    public class WeatherData
    {
        public Request request { get; set; }
        public Location location { get; set; }
        public Current current { get; set; }
    }

    public class Request
    {
        public string type { get; set; }
        public string query { get; set; }
        public string language { get; set; }
        public string unit { get; set; }
    }

    public class Location
    {
        public string name { get; set; }
        public string country { get; set; }
        public string region { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
        public string timezone_id { get; set; }
        public string localtime { get; set; }
        public int localtime_epoch { get; set; }
        public string utc_offset { get; set; }
    }

    public class Current
    {
        public string observation_time { get; set; }
        public int temperature { get; set; }
        public int weather_code { get; set; }
        public string[] weather_icons { get; set; }
        public string[] weather_descriptions { get; set; }
        public Astro astro { get; set; }
        public Air_Quality air_quality { get; set; }
        public int wind_speed { get; set; }
        public int wind_degree { get; set; }
        public string wind_dir { get; set; }
        public int pressure { get; set; }
        public double precip { get; set; }
        public int humidity { get; set; }
        public int cloudcover { get; set; }
        public int feelslike { get; set; }
        public int uv_index { get; set; }
        public int visibility { get; set; }
        public string is_day { get; set; }
    }

    public class Astro
    {
        public string sunrise { get; set; }
        public string sunset { get; set; }
        public string moonrise { get; set; }
        public string moonset { get; set; }
        public string moon_phase { get; set; }
        public int moon_illumination { get; set; }
    }

    public class Air_Quality
    {
        public string co { get; set; }
        public string no2 { get; set; }
        public string o3 { get; set; }
        public string so2 { get; set; }
        public string pm2_5 { get; set; }
        public string pm10 { get; set; }
        public string usepaindex { get; set; }
        public string gbdefraindex { get; set; }
    }

}
