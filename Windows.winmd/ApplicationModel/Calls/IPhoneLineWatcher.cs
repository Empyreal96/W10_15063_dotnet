// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IPhoneLineWatcher
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [ExclusiveTo(typeof (PhoneLineWatcher))]
  [ContractVersion(typeof (CallsPhoneContract), 65536)]
  [Guid(2319830282, 25379, 17632, 166, 246, 159, 33, 246, 77, 201, 10)]
  internal interface IPhoneLineWatcher
  {
    void Start();

    void Stop();

    event TypedEventHandler<PhoneLineWatcher, PhoneLineWatcherEventArgs> LineAdded;

    event TypedEventHandler<PhoneLineWatcher, PhoneLineWatcherEventArgs> LineRemoved;

    event TypedEventHandler<PhoneLineWatcher, PhoneLineWatcherEventArgs> LineUpdated;

    event TypedEventHandler<PhoneLineWatcher, object> EnumerationCompleted;

    event TypedEventHandler<PhoneLineWatcher, object> Stopped;

    PhoneLineWatcherStatus Status { get; }
  }
}
