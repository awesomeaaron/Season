using System;

namespace DateApp
{
    public interface IDateProvider
    {
        DateTime UtcNow { get; }
    }
}