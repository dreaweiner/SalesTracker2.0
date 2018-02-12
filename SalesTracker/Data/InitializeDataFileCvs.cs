using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Sales_Tracker;

namespace The_Sales_Tracker
{
    public class InitializeDataFileCsv
    {
        public void SeedDataFile()
        {
            CsvServices csvService = new CsvServices(DataSettings.dataFilePathCsv);

            csvService.WriteSalespersonToDataFile(InitializeSalesperson());
        }

        private Salesperson InitializeSalesperson()
        {
            Salesperson salesperson = new Salesperson()
            {
                FirstName = "Bonzo",
                LastName = "Regan",
                AccountID = "banana103",
                CurrentStock = new Product(Product.ProductType.Sphero, 20, false),
                CitiesVisited = new List<string>()
                {
                    "Detroit",
                    "Grand Rapids",
                    "Ann Arbor"
                }
            };

            return salesperson;
        }
    }
}
