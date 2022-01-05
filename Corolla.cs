namespace interfaceexample
{
    public class Corolla : IAutomobile
    {
        public int HowManyWheels()
        {
            return 4 ;
            
        }

        public BrandName WhichBrand()
        {
                return BrandName.Toyota ;
        }

        public Color WhichColor()
        {
            return Color.Grey ;
            
        }
    }
}