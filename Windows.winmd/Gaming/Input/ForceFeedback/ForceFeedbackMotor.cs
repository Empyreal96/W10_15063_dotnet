// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.ForceFeedback.ForceFeedbackMotor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.ForceFeedback
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772162)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ForceFeedbackMotor : IForceFeedbackMotor
  {
    public extern bool AreEffectsPaused { [MethodImpl] get; }

    public extern double MasterGain { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsEnabled { [MethodImpl] get; }

    public extern ForceFeedbackEffectAxes SupportedAxes { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ForceFeedbackLoadEffectResult> LoadEffectAsync(
      IForceFeedbackEffect effect);

    [MethodImpl]
    public extern void PauseAllEffects();

    [MethodImpl]
    public extern void ResumeAllEffects();

    [MethodImpl]
    public extern void StopAllEffects();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryDisableAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryEnableAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryResetAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryUnloadEffectAsync(
      IForceFeedbackEffect effect);
  }
}
