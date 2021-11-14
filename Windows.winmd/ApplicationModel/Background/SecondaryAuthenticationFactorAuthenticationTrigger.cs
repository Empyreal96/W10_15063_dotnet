// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.SecondaryAuthenticationFactorAuthenticationTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class SecondaryAuthenticationFactorAuthenticationTrigger : 
    ISecondaryAuthenticationFactorAuthenticationTrigger,
    IBackgroundTrigger
  {
    [MethodImpl]
    public extern SecondaryAuthenticationFactorAuthenticationTrigger();
  }
}
