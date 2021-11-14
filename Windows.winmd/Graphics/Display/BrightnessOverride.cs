// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.BrightnessOverride
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  [Static(typeof (IBrightnessOverrideStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class BrightnessOverride : IBrightnessOverride
  {
    public extern bool IsSupported { [MethodImpl] get; }

    public extern bool IsOverrideActive { [MethodImpl] get; }

    public extern double BrightnessLevel { [MethodImpl] get; }

    [MethodImpl]
    public extern void SetBrightnessLevel(
      double brightnessLevel,
      DisplayBrightnessOverrideOptions options);

    [MethodImpl]
    public extern void SetBrightnessScenario(
      DisplayBrightnessScenario scenario,
      DisplayBrightnessOverrideOptions options);

    [MethodImpl]
    public extern double GetLevelForScenario(DisplayBrightnessScenario scenario);

    [MethodImpl]
    public extern void StartOverride();

    [MethodImpl]
    public extern void StopOverride();

    public extern event TypedEventHandler<BrightnessOverride, object> IsSupportedChanged;

    public extern event TypedEventHandler<BrightnessOverride, object> IsOverrideActiveChanged;

    public extern event TypedEventHandler<BrightnessOverride, object> BrightnessLevelChanged;

    [MethodImpl]
    public static extern BrightnessOverride GetDefaultForSystem();

    [MethodImpl]
    public static extern BrightnessOverride GetForCurrentView();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> SaveForSystemAsync(
      BrightnessOverride value);
  }
}
