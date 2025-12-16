namespace RapidApiDemoNew.Models
{
    public class FuelViewModel
    {
        public bool success { get; set; }
        public List<FuelResult> result { get; set; }
    }

    public class FuelResult
    {
        public string currency { get; set; }
        public string lpg { get; set; }
        public string diesel { get; set; }
        public string gasoline { get; set; }
        public string country { get; set; }
    }
}
