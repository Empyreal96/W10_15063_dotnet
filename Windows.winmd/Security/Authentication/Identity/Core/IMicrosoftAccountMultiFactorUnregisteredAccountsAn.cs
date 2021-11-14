// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Core.IMicrosoftAccountMultiFactorUnregisteredAccountsAndSessionInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Core
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2860434939, 55871, 16520, 162, 13, 86, 24, 175, 173, 178, 229)]
  [ExclusiveTo(typeof (MicrosoftAccountMultiFactorUnregisteredAccountsAndSessionInfo))]
  internal interface IMicrosoftAccountMultiFactorUnregisteredAccountsAndSessionInfo
  {
    IVectorView<MicrosoftAccountMultiFactorSessionInfo> Sessions { get; }

    IVectorView<string> UnregisteredAccounts { get; }

    MicrosoftAccountMultiFactorServiceResponse ServiceResponse { get; }
  }
}
