// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureInitializationSettings3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Core;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaCaptureInitializationSettings))]
  [Guid(1096831389, 48712, 18224, 129, 4, 12, 246, 233, 233, 121, 72)]
  internal interface IMediaCaptureInitializationSettings3
  {
    IMediaSource AudioSource { set; get; }

    IMediaSource VideoSource { set; get; }
  }
}
