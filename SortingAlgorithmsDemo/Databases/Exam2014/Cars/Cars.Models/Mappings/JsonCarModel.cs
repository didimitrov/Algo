namespace Cars.Models.Mappings
{
    public class JsonCarModel
    {
        public JsonCarModel()
        {
            
        }

        public int Year { get; set; }

        public int TransmissionType { get; set; }

        public string ManufacturerName { get; set; }

        public string Model { get; set; }

        public decimal Price { get; set; }

       public JsonDealerModel Dealer { get; set; }
    }
}
