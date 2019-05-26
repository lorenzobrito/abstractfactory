
using System;
namespace patternc
{
    public class DeliveryCenter 
    {
        private Product _product;
        private RegionCLient _region;
        ContinentFactory _factory;
        public DeliveryCenter(ContinentFactory factory)
        {
            _factory=factory;
            _product=factory.getProduct();
            _region=factory.getRegionCLient();

        }

        public void Deliver()
        {
            _region.setProducts(_product);
            Console.WriteLine($" {_region.NameRegion}");
            Console.WriteLine($"{_product.PorcentPage}");
            Console.WriteLine($"{_factory.getDeliveryTime()}");
            
        }

    }

}