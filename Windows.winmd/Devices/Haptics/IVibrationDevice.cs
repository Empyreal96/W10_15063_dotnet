// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Haptics.IVibrationDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Haptics
{
  [Guid(1089608254, 34884, 18431, 179, 18, 6, 24, 90, 56, 68, 218)]
  [ExclusiveTo(typeof (VibrationDevice))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IVibrationDevice
  {
    string Id { get; }

    SimpleHapticsController SimpleHapticsController { get; }
  }
}
