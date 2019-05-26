
namespace patternc
{
    public class AmericaRegion : RegionCLient
    {
        public double RegionalPorcent {get;protected set;}
        public override string NameRegion { get;set; }

        public AmericaRegion()
        {
            NameRegion="America Continent";

        }

        public override void setProducts(Product product)
        {
           this.RegionalPorcent=product.PorcentPage;
        }
    }

}