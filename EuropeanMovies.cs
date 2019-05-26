
namespace patternc
{
    public class EuropeanMovies : Product
    {
        public EuropeanMovies()
        {
            base.minimumProducts=900;
            base.PorcentPage=15;
            base.MovieCode = new System.Collections.Generic.List<string>(){"F20","G10","E10","N00"};

        }
    }

}