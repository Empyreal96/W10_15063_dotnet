// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynStatusStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [ExclusiveTo(typeof (AllJoynStatus))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3501695358, 3369, 19881, 138, 198, 84, 197, 84, 190, 219, 197)]
  internal interface IAllJoynStatusStatics
  {
    int Ok { get; }

    int Fail { get; }

    int OperationTimedOut { get; }

    int OtherEndClosed { get; }

    int ConnectionRefused { get; }

    int AuthenticationFailed { get; }

    int AuthenticationRejectedByUser { get; }

    int SslConnectFailed { get; }

    int SslIdentityVerificationFailed { get; }

    int InsufficientSecurity { get; }

    int InvalidArgument1 { get; }

    int InvalidArgument2 { get; }

    int InvalidArgument3 { get; }

    int InvalidArgument4 { get; }

    int InvalidArgument5 { get; }

    int InvalidArgument6 { get; }

    int InvalidArgument7 { get; }

    int InvalidArgument8 { get; }
  }
}
