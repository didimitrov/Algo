using System.Collections.Generic;
using System.IO;
using System.Linq;
using Cars.Data.Contracts;
using Cars.Models;
using Cars.Models.Mappings;
using Newtonsoft.Json;

namespace Cars.ConsoleClient
{
    public class DataJsonImporter
    {
        private readonly ICarsDbContext _carsContext;

        public DataJsonImporter(ICarsDbContext carsContext)
        {
            this._carsContext = carsContext;
        }

        public void Import(string directoryPath)
        {
            var files = Directory.EnumerateFiles(directoryPath);

            foreach (var file in files)
            {
                using (var reader = new StreamReader(file))
                {
                    string json = reader.ReadToEnd();
                    var cars = JsonConvert.DeserializeObject<List<JsonCarModel>>(json);

                    foreach (var jsonCarModel in cars)
                    {
                        var newCar = new Car
                        {
                            Model = jsonCarModel.Model,
                            Year = jsonCarModel.Year,
                            Price = jsonCarModel.Price,
                            Dealer = GetOrCreateDealer(jsonCarModel.Dealer.Name),
                            Manufacturer = GetOrCreateManifacturer(jsonCarModel.ManufacturerName),
                            Transmission = GetOrCreateTransmission(jsonCarModel.TransmissionType)
                        };

                        _carsContext.Cars.Add(newCar);
                        _carsContext.SaveChanges();
                    }
                }
            }
        }

        private Transmission GetOrCreateTransmission(int transmissionType)
        {
            if (transmissionType==0)
            {
                return Transmission.Manual;
            }
            return Transmission.Automatic;
        }

        private Manufacturer GetOrCreateManifacturer(string manufacturerName)
        {
            var manufacturer = _carsContext.Manufacturers.SingleOrDefault(m => m.Name == manufacturerName);
            if (manufacturer==null)
            {
                manufacturer = new Manufacturer
                {
                    Name = manufacturerName
                };
            }
            return manufacturer;
        }

        private Dealer GetOrCreateDealer(string name)
        {
            var dealer = _carsContext.Dealers.SingleOrDefault(d => d.Name == name);
           
            if (dealer == null)
            {
                dealer = new Dealer
                {
                    Name = name
                };
            }

            return dealer;
        }
    }
}
