namespace interfaceexample
{
    public class Civic : IAutomobile
    {   
        public int HowManyWheels()
        {
            return 4 ;
            
        }

        public BrandName WhichBrand()
        {
                return BrandName.Honda ;
        }

        public Color WhichColor()
        {
            return Color.White ;
            
        }
    }

   
}