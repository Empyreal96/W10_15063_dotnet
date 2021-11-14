// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Core.MicrosoftAccountMultiFactorSessionInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Core
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MicrosoftAccountMultiFactorSessionInfo : 
    IMicrosoftAccountMultiFactorSessionInfo
  {
    public extern string UserAccountId { [MethodImpl] get; }

    public extern string SessionId { [MethodImpl] get; }

    public extern string DisplaySessionId { [MethodImpl] get; }

    public extern MicrosoftAccountMultiFactorSessionApprovalStatus ApprovalStatus { [MethodImpl] get; }

    public extern MicrosoftAccountMultiFactorAuthenticationType AuthenticationType { [MethodImpl] get; }

    public extern DateTime RequestTime { [MethodImpl] get; }

    public extern DateTime ExpirationTime { [MethodImpl] get; }
  }
}
