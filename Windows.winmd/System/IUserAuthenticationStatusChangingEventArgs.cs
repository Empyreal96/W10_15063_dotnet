// Decompiled with JetBrains decompiler
// Type: Windows.System.IUserAuthenticationStatusChangingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [Guid(2349010728, 42769, 19486, 171, 72, 4, 23, 156, 21, 147, 143)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UserAuthenticationStatusChangingEventArgs))]
  internal interface IUserAuthenticationStatusChangingEventArgs
  {
    UserAuthenticationStatusChangeDeferral GetDeferral();

    User User { get; }

    UserAuthenticationStatus NewStatus { get; }

    UserAuthenticationStatus CurrentStatus { get; }
  }
}
