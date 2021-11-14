// Decompiled with JetBrains decompiler
// Type: Windows.System.UserWatcher
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UserWatcher : IUserWatcher
  {
    public extern UserWatcherStatus Status { [MethodImpl] get; }

    [MethodImpl]
    public extern void Start();

    [MethodImpl]
    public extern void Stop();

    public extern event TypedEventHandler<UserWatcher, UserChangedEventArgs> Added;

    public extern event TypedEventHandler<UserWatcher, UserChangedEventArgs> Removed;

    public extern event TypedEventHandler<UserWatcher, UserChangedEventArgs> Updated;

    public extern event TypedEventHandler<UserWatcher, UserChangedEventArgs> AuthenticationStatusChanged;

    public extern event TypedEventHandler<UserWatcher, UserAuthenticationStatusChangingEventArgs> AuthenticationStatusChanging;

    public extern event TypedEventHandler<UserWatcher, object> EnumerationCompleted;

    public extern event TypedEventHandler<UserWatcher, object> Stopped;
  }
}
