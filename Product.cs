

using System.Collections.Generic;
namespace patternc
{
public abstract class Product {

    public int minimumProducts {get;protected set;}
    
    public double PorcentPage {get;protected set;}
    public int NumberOfProducts{get;set;}

    public List<string> MovieCode {get;protected set;}
}
}