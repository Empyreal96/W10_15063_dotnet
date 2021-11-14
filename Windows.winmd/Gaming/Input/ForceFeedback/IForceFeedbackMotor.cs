// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.ForceFeedback.IForceFeedbackMotor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.ForceFeedback
{
  [Guid(2369601916, 42474, 17686, 128, 38, 43, 0, 247, 78, 246, 229)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (ForceFeedbackMotor))]
  internal interface IForceFeedbackMotor
  {
    bool AreEffectsPaused { get; }

    double MasterGain { get; set; }

    bool IsEnabled { get; }

    ForceFeedbackEffectAxes SupportedAxes { get; }

    [RemoteAsync]
    IAsyncOperation<ForceFeedbackLoadEffectResult> LoadEffectAsync(
      IForceFeedbackEffect effect);

    void PauseAllEffects();

    void ResumeAllEffects();

    void StopAllEffects();

    [RemoteAsync]
    IAsyncOperation<bool> TryDisableAsync();

    [RemoteAsync]
    IAsyncOperation<bool> TryEnableAsync();

    [RemoteAsync]
    IAsyncOperation<bool> TryResetAsync();

    [RemoteAsync]
    IAsyncOperation<bool> TryUnloadEffectAsync(IForceFeedbackEffect effect);
  }
}
