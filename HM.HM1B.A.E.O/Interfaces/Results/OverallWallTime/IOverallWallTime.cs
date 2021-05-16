namespace HM.HM1B.A.E.O.Interfaces.Results.OverallWallTime
{
    using System;

    public interface IOverallWallTime
    {
        TimeSpan Value { get; }

        TimeSpan GetValueForOutputContext();
    }
}