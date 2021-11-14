// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynStatus
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IAllJoynStatusStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  public static class AllJoynStatus
  {
    public static extern int Ok { [MethodImpl] get; }

    public static extern int Fail { [MethodImpl] get; }

    public static extern int OperationTimedOut { [MethodImpl] get; }

    public static extern int OtherEndClosed { [MethodImpl] get; }

    public static extern int ConnectionRefused { [MethodImpl] get; }

    public static extern int AuthenticationFailed { [MethodImpl] get; }

    public static extern int AuthenticationRejectedByUser { [MethodImpl] get; }

    public static extern int SslConnectFailed { [MethodImpl] get; }

    public static extern int SslIdentityVerificationFailed { [MethodImpl] get; }

    public static extern int InsufficientSecurity { [MethodImpl] get; }

    public static extern int InvalidArgument1 { [MethodImpl] get; }

    public static extern int InvalidArgument2 { [MethodImpl] get; }

    public static extern int InvalidArgument3 { [MethodImpl] get; }

    public static extern int InvalidArgument4 { [MethodImpl] get; }

    public static extern int InvalidArgument5 { [MethodImpl] get; }

    public static extern int InvalidArgument6 { [MethodImpl] get; }

    public static extern int InvalidArgument7 { [MethodImpl] get; }

    public static extern int InvalidArgument8 { [MethodImpl] get; }
  }
}
