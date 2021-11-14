// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IsoSpeedPreset
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [Deprecated("IsoSpeedPreset may not be available in future versions of Windows Phone. Starting with Windows Phone 8.1, use SetAutoAsync, Auto, SetValueAsync, and Value instead", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum IsoSpeedPreset
  {
    Auto,
    Iso50,
    Iso80,
    Iso100,
    Iso200,
    Iso400,
    Iso800,
    Iso1600,
    Iso3200,
    Iso6400,
    Iso12800,
    Iso25600,
  }
}
