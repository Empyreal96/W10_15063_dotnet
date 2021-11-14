// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IAdvancedPhotoCaptureSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ExclusiveTo(typeof (AdvancedPhotoCaptureSettings))]
  [Guid(150177338, 24, 17499, 147, 210, 100, 109, 28, 94, 208, 92)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAdvancedPhotoCaptureSettings
  {
    AdvancedPhotoMode Mode { get; set; }
  }
}
