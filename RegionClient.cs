using System.Collections.Generic;
namespace patternc
{
public abstract class RegionCLient
{
public List<string> Countries {get;set;}
   public abstract void setProducts(Product product);
public abstract string NameRegion{get;set;}
}
}