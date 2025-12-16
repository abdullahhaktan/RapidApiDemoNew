namespace RapidApiDemoNew.Models
{
    public class ConvertResponse
    {
        public Info info { get; set; }
    }

    public class Info
    {
        public double rate { get; set; }
    }

    public class DashboardViewModel
    {
        public double UsdTry { get; set; }
        public double EurTry { get; set; }
        public double BtcUsd {  get; set; }
        public double EthUsd { get; set; }
        public double UsdTryChange { get; set; }
        public double EurTryChange { get; set; }
        public double BtcChange { get; set; }
        public double EthChange { get; set; }
    }
}
