// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.ISecondaryAuthenticationFactorAuthenticationStageInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1459536523, 59562, 19471, 142, 76, 165, 89, 231, 58, 221, 136)]
  [ExclusiveTo(typeof (SecondaryAuthenticationFactorAuthenticationStageInfo))]
  internal interface ISecondaryAuthenticationFactorAuthenticationStageInfo
  {
    SecondaryAuthenticationFactorAuthenticationStage Stage { get; }

    SecondaryAuthenticationFactorAuthenticationScenario Scenario { get; }

    string DeviceId { get; }
  }
}
