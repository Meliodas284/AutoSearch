namespace AutoSearch
{
    public class Auto
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public string Category { get; set; }
        public string EngineType { get; set; }
        public int Powers { get; set; }
        public string Transmission { get; set; }
        public string GearType { get; set; }
        public string Wheel { get; set; }
        public string Image { get; set; }
        public ulong Price { get; set; }

        public override string ToString()
        {
            string text = $"{Mark}\n{Model}\n{Category}\n{EngineType}\n{Powers}\n{Transmission}\n{GearType}\n{Wheel}\n{Image}\n{Price}";
            return text;
        }
    }
}
