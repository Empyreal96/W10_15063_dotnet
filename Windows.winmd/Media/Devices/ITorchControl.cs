// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.ITorchControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [Guid(2785359461, 33360, 16748, 145, 154, 114, 66, 150, 175, 163, 6)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TorchControl))]
  internal interface ITorchControl
  {
    bool Supported { get; }

    bool PowerSupported { get; }

    bool Enabled { get; set; }

    float PowerPercent { get; set; }
  }
}
