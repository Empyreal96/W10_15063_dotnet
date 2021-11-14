// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IZoomControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ExclusiveTo(typeof (ZoomControl))]
  [Guid(975047442, 13018, 19479, 191, 215, 141, 12, 115, 200, 245, 165)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IZoomControl
  {
    bool Supported { get; }

    float Min { get; }

    float Max { get; }

    float Step { get; }

    float Value { get; set; }
  }
}
