// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.Radio.FMRadio
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Security;

namespace Microsoft.Devices.Radio
{
  [SecuritySafeCritical]
  public sealed class FMRadio
  {
    private static FMRadio _Instance = new FMRadio();
    private RadioRegion _thisRegion;
    private RadioPowerMode _powerMode;

    private FMRadio()
    {
      this._thisRegion = RadioRegion.UnitedStates;
      uint fPlaying;
      RadioApiNativeMethods.MediaApi_GetRadioPlaying(out fPlaying);
      this._powerMode = fPlaying == 0U ? RadioPowerMode.Off : RadioPowerMode.On;
    }

    public static FMRadio Instance
    {
      get
      {
        FMRadio.ValidateRadioSetting_Internal();
        return FMRadio._Instance;
      }
    }

    public RadioRegion CurrentRegion
    {
      set => this._thisRegion = value;
      get => this._thisRegion;
    }

    public RadioPowerMode PowerMode
    {
      set => this.SetRadioPowerMode_Internal(value);
      get => this._powerMode;
    }

    [SecuritySafeCritical]
    private void SetRadioPowerMode_Internal(RadioPowerMode value)
    {
      this._powerMode = value;
      RadioApiNativeMethods.MediaApi_EnableRadio((uint) this._powerMode);
    }

    public double Frequency
    {
      get => this.GetFrequency_Internal();
      set => this.SetFrequency_Internal(value);
    }

    [SecuritySafeCritical]
    private void SetFrequency_Internal(double value)
    {
      if (value < 0.0 || value > 1000.0)
        throw new ArgumentOutOfRangeException(nameof (value));
      RadioApiNativeMethods.MediaApi_TuneRadio((uint) this._thisRegion, (uint) (value * 1000.0));
    }

    [SecuritySafeCritical]
    private double GetFrequency_Internal()
    {
      uint KHz;
      RadioApiNativeMethods.MediaApi_GetRadioFrequency(out KHz);
      return (double) KHz / 1000.0;
    }

    [SecuritySafeCritical]
    private static void ValidateRadioSetting_Internal()
    {
      uint fEnabled;
      RadioApiNativeMethods.MediaApi_GetRadioEnabled(out fEnabled);
      if (fEnabled == 0U)
        throw new RadioDisabledException();
    }

    public double SignalStrength => this.GetSignalStrength_Internal();

    [SecuritySafeCritical]
    private double GetSignalStrength_Internal()
    {
      uint currentRssi;
      uint maxRssi;
      RadioApiNativeMethods.MediaApi_GetRadioQuality(out currentRssi, out maxRssi);
      return currentRssi == 0U || maxRssi == 0U ? 0.0 : (double) currentRssi / (double) maxRssi;
    }
  }
}
