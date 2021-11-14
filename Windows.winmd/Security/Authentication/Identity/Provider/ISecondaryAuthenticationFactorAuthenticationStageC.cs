// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.ISecondaryAuthenticationFactorAuthenticationStageChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Provider
{
  [Guid(3567644246, 29329, 16499, 188, 31, 204, 184, 245, 175, 223, 150)]
  [ExclusiveTo(typeof (SecondaryAuthenticationFactorAuthenticationStageChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface ISecondaryAuthenticationFactorAuthenticationStageChangedEventArgs
  {
    SecondaryAuthenticationFactorAuthenticationStageInfo StageInfo { get; }
  }
}
