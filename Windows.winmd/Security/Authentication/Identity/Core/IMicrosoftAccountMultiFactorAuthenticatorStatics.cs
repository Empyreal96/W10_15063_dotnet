// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Core.IMicrosoftAccountMultiFactorAuthenticatorStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Core
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3647259366, 62534, 19569, 139, 121, 110, 164, 2, 74, 169, 184)]
  [ExclusiveTo(typeof (MicrosoftAccountMultiFactorAuthenticationManager))]
  internal interface IMicrosoftAccountMultiFactorAuthenticatorStatics
  {
    MicrosoftAccountMultiFactorAuthenticationManager Current { get; }
  }
}
