// Decompiled with JetBrains decompiler
// Type: Windows.System.UserAuthenticationStatusChangingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class UserAuthenticationStatusChangingEventArgs : 
    IUserAuthenticationStatusChangingEventArgs
  {
    [MethodImpl]
    public extern UserAuthenticationStatusChangeDeferral GetDeferral();

    public extern User User { [MethodImpl] get; }

    public extern UserAuthenticationStatus NewStatus { [MethodImpl] get; }

    public extern UserAuthenticationStatus CurrentStatus { [MethodImpl] get; }
  }
}
