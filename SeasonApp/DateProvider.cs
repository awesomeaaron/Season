using System;

namespace DateApp
{
    public class DateProvider : IDateProvider
    {
        public DateTime UtcNow =>  DateTime.UtcNow;
    }
}
