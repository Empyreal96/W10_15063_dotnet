// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureInitializationSettings6
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [Guid(3001183047, 15793, 19763, 171, 99, 15, 250, 9, 5, 101, 133)]
  [ExclusiveTo(typeof (MediaCaptureInitializationSettings))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IMediaCaptureInitializationSettings6
  {
    bool AlwaysPlaySystemShutterSound { get; set; }
  }
}
