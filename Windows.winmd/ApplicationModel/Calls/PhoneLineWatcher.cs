// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.PhoneLineWatcher
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (CallsPhoneContract), 65536)]
  public sealed class PhoneLineWatcher : IPhoneLineWatcher
  {
    [MethodImpl]
    public extern void Start();

    [MethodImpl]
    public extern void Stop();

    public extern event TypedEventHandler<PhoneLineWatcher, PhoneLineWatcherEventArgs> LineAdded;

    public extern event TypedEventHandler<PhoneLineWatcher, PhoneLineWatcherEventArgs> LineRemoved;

    public extern event TypedEventHandler<PhoneLineWatcher, PhoneLineWatcherEventArgs> LineUpdated;

    public extern event TypedEventHandler<PhoneLineWatcher, object> EnumerationCompleted;

    public extern event TypedEventHandler<PhoneLineWatcher, object> Stopped;

    public extern PhoneLineWatcherStatus Status { [MethodImpl] get; }
  }
}
