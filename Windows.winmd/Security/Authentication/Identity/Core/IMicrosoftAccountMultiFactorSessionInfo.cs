// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Core.IMicrosoftAccountMultiFactorSessionInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Core
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1602137012, 41592, 17973, 183, 101, 180, 148, 235, 38, 10, 244)]
  [ExclusiveTo(typeof (MicrosoftAccountMultiFactorSessionInfo))]
  internal interface IMicrosoftAccountMultiFactorSessionInfo
  {
    string UserAccountId { get; }

    string SessionId { get; }

    string DisplaySessionId { get; }

    MicrosoftAccountMultiFactorSessionApprovalStatus ApprovalStatus { get; }

    MicrosoftAccountMultiFactorAuthenticationType AuthenticationType { get; }

    DateTime RequestTime { get; }

    DateTime ExpirationTime { get; }
  }
}
