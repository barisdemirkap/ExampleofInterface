namespace interfaceexample
{
    public class Focus : IAutomobile
    {
        public int HowManyWheels()
        {
            return 4 ;
            
        }

        public BrandName WhichBrand()
        {
                return BrandName.Ford ;
        }

        public Color WhichColor()
        {
            return Color.Green ;
            
        }
    }
}