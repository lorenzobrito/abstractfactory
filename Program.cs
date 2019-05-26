using System;

namespace patternc
{
    class Program
    {
        static void Main(string[] args)
        {
            ContinentFactory america=new AmericaFactory();
            DeliveryCenter center = new   DeliveryCenter(america);
            center.Deliver();

            ContinentFactory europa = new EuropeanFactory();
            center = new DeliveryCenter(europa);
            center.Deliver();
        }
    }
}
