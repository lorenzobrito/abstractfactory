
namespace patternc
{
    public class EuropeanFactory : ContinentFactory
    {
      
        public EuropeanFactory()
        {
            

        }

        public override Product getProduct()
        {
            
            return new EuropeanMovies();
        }

        public override RegionCLient getRegionCLient()
        {
            return new EuropaRegion();
        }
    }

}