

namespace patternc
{
    public abstract class ContinentFactory
    {
      public  ContinentFactory()
        {
DeliveryTime="7 days";
        }
       public abstract Product getProduct();
       public abstract RegionCLient getRegionCLient();
       
       protected string DeliveryTime; 
       public string getDeliveryTime()
       {
           return DeliveryTime;
       } 
       protected virtual void setDeliveryTIme()
       {
            if(this.getProduct().NumberOfProducts>500)
            DeliveryTime="15 days";
            if(this.getProduct().NumberOfProducts>1000)
            DeliveryTime="20 days";

       }
 



    }

}