// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.FocusControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class FocusControl : IFocusControl, IFocusControl2
  {
    public extern bool Supported { [MethodImpl] get; }

    public extern IVectorView<FocusPreset> SupportedPresets { [MethodImpl] get; }

    public extern FocusPreset Preset { [MethodImpl] get; }

    [Overload("SetPresetAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetPresetAsync(FocusPreset preset);

    [Overload("SetPresetWithCompletionOptionAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetPresetAsync(
      FocusPreset preset,
      bool completeBeforeFocus);

    public extern uint Min { [MethodImpl] get; }

    public extern uint Max { [MethodImpl] get; }

    public extern uint Step { [MethodImpl] get; }

    public extern uint Value { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetValueAsync(uint focus);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction FocusAsync();

    public extern bool FocusChangedSupported { [MethodImpl] get; }

    public extern bool WaitForFocusSupported { [MethodImpl] get; }

    public extern IVectorView<FocusMode> SupportedFocusModes { [MethodImpl] get; }

    public extern IVectorView<ManualFocusDistance> SupportedFocusDistances { [MethodImpl] get; }

    public extern IVectorView<AutoFocusRange> SupportedFocusRanges { [MethodImpl] get; }

    public extern FocusMode Mode { [MethodImpl] get; }

    public extern MediaCaptureFocusState FocusState { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction UnlockAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction LockAsync();

    [MethodImpl]
    public extern void Configure(FocusSettings settings);
  }
}
