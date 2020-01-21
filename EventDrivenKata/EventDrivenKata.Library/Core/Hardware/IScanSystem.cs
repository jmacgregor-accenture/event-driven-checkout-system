using System;

namespace EventDrivenKata.Library.Core.Hardware
{
    public interface IScanSystem
    {
        event EventHandler<ScannedEventArgs> ItemScannedEvent;
        event EventHandler<WeighedEventArgs> ItemWeighedEvent;

    }
}