// Decompiled with JetBrains decompiler
// Type: Windows.System.IUserWatcher
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UserWatcher))]
  [Guid(358527547, 9258, 17888, 162, 233, 49, 113, 252, 106, 127, 187)]
  internal interface IUserWatcher
  {
    UserWatcherStatus Status { get; }

    void Start();

    void Stop();

    event TypedEventHandler<UserWatcher, UserChangedEventArgs> Added;

    event TypedEventHandler<UserWatcher, UserChangedEventArgs> Removed;

    event TypedEventHandler<UserWatcher, UserChangedEventArgs> Updated;

    event TypedEventHandler<UserWatcher, UserChangedEventArgs> AuthenticationStatusChanged;

    event TypedEventHandler<UserWatcher, UserAuthenticationStatusChangingEventArgs> AuthenticationStatusChanging;

    event TypedEventHandler<UserWatcher, object> EnumerationCompleted;

    event TypedEventHandler<UserWatcher, object> Stopped;
  }
}
