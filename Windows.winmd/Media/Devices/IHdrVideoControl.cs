// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IHdrVideoControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ExclusiveTo(typeof (HdrVideoControl))]
  [Guid(1440277200, 12480, 17343, 155, 154, 151, 153, 215, 12, 237, 148)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHdrVideoControl
  {
    bool Supported { get; }

    IVectorView<HdrVideoMode> SupportedModes { get; }

    HdrVideoMode Mode { get; set; }
  }
}
