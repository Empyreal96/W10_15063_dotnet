// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IAdvancedCapturedPhoto
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Devices;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AdvancedCapturedPhoto))]
  [Guid(4034032267, 45714, 17553, 157, 65, 153, 128, 122, 85, 11, 191)]
  internal interface IAdvancedCapturedPhoto
  {
    CapturedFrame Frame { get; }

    AdvancedPhotoMode Mode { get; }

    object Context { get; }
  }
}
