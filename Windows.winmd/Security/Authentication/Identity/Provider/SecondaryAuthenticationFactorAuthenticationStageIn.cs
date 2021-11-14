// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorAuthenticationStageInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Provider
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772162)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class SecondaryAuthenticationFactorAuthenticationStageInfo : 
    ISecondaryAuthenticationFactorAuthenticationStageInfo
  {
    public extern SecondaryAuthenticationFactorAuthenticationStage Stage { [MethodImpl] get; }

    public extern SecondaryAuthenticationFactorAuthenticationScenario Scenario { [MethodImpl] get; }

    public extern string DeviceId { [MethodImpl] get; }
  }
}
