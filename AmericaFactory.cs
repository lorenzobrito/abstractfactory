
namespace patternc
{
    public class AmericaFactory : ContinentFactory
    {
      
        public AmericaFactory()
        {
            

        }

        public override Product getProduct()
        {
            
            return new AmericaMovies();
        }

        public override RegionCLient getRegionCLient()
        {
            return new AmericaRegion();
        }

        protected override void setDeliveryTIme(){
            base.setDeliveryTIme();
             if(this.getProduct().NumberOfProducts>1500)
            DeliveryTime="22 days";
            if(this.getProduct().NumberOfProducts>10000)
            DeliveryTime="30 days";
        }
    }

}