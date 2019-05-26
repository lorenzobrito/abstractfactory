
namespace patternc
{
    public class EuropaRegion : RegionCLient
    {
        public double RegionalPorcent {get;protected set;}

        public override string NameRegion { get;set; }
        public EuropaRegion()
        {
            NameRegion="Europa";

        }

        public override void setProducts(Product product)
        {
           this.RegionalPorcent=product.PorcentPage;
        }

       
    }

}