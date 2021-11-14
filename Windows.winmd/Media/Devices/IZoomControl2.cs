// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IZoomControl2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ZoomControl))]
  [Guid(1770274224, 11929, 17985, 133, 41, 24, 79, 49, 157, 22, 113)]
  internal interface IZoomControl2
  {
    IVectorView<ZoomTransitionMode> SupportedModes { get; }

    ZoomTransitionMode Mode { get; }

    void Configure(ZoomSettings settings);
  }
}
