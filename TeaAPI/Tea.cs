using System;

namespace TeaAPI
{
    public class Tea
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string TeaType { get; set; }
    }
}
