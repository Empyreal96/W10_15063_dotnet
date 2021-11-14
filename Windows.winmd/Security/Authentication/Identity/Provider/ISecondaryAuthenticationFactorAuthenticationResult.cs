// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.ISecondaryAuthenticationFactorAuthenticationResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Provider
{
  [Guid(2629523847, 61293, 19394, 191, 73, 70, 23, 81, 90, 15, 154)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (SecondaryAuthenticationFactorAuthenticationResult))]
  internal interface ISecondaryAuthenticationFactorAuthenticationResult
  {
    SecondaryAuthenticationFactorAuthenticationStatus Status { get; }

    SecondaryAuthenticationFactorAuthentication Authentication { get; }
  }
}
