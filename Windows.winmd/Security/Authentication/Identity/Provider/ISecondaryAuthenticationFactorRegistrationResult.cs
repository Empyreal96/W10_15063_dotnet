// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.ISecondaryAuthenticationFactorRegistrationResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (SecondaryAuthenticationFactorRegistrationResult))]
  [Guid(2768123376, 44515, 18817, 175, 107, 236, 25, 89, 33, 104, 42)]
  internal interface ISecondaryAuthenticationFactorRegistrationResult
  {
    SecondaryAuthenticationFactorRegistrationStatus Status { get; }

    SecondaryAuthenticationFactorRegistration Registration { get; }
  }
}
