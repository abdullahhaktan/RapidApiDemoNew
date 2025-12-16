namespace RapidApiDemoNew.Models
{
    public class HotelSearchRequest
    {
        public string dest_id { get; set; }
        public string city { get; set; }
        public string search_type { get; set; }
        public int adults { get; set; }
        public string children_age { get; set; }
        public int room_qty { get; set; }
        public int page_number { get; set; }
        public string units { get; set; }
        public string temperature_unit { get; set; }
        public string languagecode { get; set; }
        public string currency_code { get; set; }
        public string location { get; set; }
        public string arrival_date { get; set; }
        public string departure_date { get; set; }
    }
}