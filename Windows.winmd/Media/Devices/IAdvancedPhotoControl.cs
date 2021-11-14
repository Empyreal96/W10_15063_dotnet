// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IAdvancedPhotoControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3316733062, 36865, 18050, 147, 9, 104, 234, 224, 8, 14, 236)]
  [ExclusiveTo(typeof (AdvancedPhotoControl))]
  internal interface IAdvancedPhotoControl
  {
    bool Supported { get; }

    IVectorView<AdvancedPhotoMode> SupportedModes { get; }

    AdvancedPhotoMode Mode { get; }

    void Configure(AdvancedPhotoCaptureSettings settings);
  }
}
