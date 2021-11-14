// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.IBrightnessOverride
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  [ExclusiveTo(typeof (BrightnessOverride))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2529780250, 49475, 17298, 190, 221, 74, 126, 149, 116, 200, 253)]
  internal interface IBrightnessOverride
  {
    bool IsSupported { get; }

    bool IsOverrideActive { get; }

    double BrightnessLevel { get; }

    void SetBrightnessLevel(double brightnessLevel, DisplayBrightnessOverrideOptions options);

    void SetBrightnessScenario(
      DisplayBrightnessScenario scenario,
      DisplayBrightnessOverrideOptions options);

    double GetLevelForScenario(DisplayBrightnessScenario scenario);

    void StartOverride();

    void StopOverride();

    event TypedEventHandler<BrightnessOverride, object> IsSupportedChanged;

    event TypedEventHandler<BrightnessOverride, object> IsOverrideActiveChanged;

    event TypedEventHandler<BrightnessOverride, object> BrightnessLevelChanged;
  }
}
