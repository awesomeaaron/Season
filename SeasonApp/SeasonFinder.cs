namespace DateApp
{
    public class SeasonFinder
    {
        public Season Find(IDateProvider dateProvider)
        {
            var month = dateProvider.UtcNow.Month;
            Season result = Season.Fall;
            
            // Summer
            if ( month >= 6 && month <= 8)
            {
                result = Season.Summer;
            }

            // Fall
            else if (month >= 9 && month <= 11)
            {
                result = Season.Fall;
            }

            // Winter
            else if (month == 12 || month <= 2)
            {
                result = Season.Winter;
            }

            // Spring
            else if (month >= 3 && month <= 5)
            {
                result = Season.Spring;
            }

            return result;
        }
    }
}
