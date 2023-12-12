using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates._2
{
    public class Program
    {
        static void Main(string[] args)
        {
            ServiceProvider serviceProvider = new ServiceProvider();
            Manufacturer manufacturer = new Manufacturer();
            manufacturer.Registerserviceprovider(serviceProvider.Manufacture);

            manufacturer.ManufactureItem();
        }
    }
}
