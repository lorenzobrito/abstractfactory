
namespace patternc
{
    public class AmericaMovies : Product
    {
        public AmericaMovies()
        {
            base.minimumProducts=1000;
            base.PorcentPage=10;
            base.MovieCode = new System.Collections.Generic.List<string>(){"","A10","A10","A00"};

        }
    }

}