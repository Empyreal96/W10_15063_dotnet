// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IPhotoCapturedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [Guid(926677953, 38990, 20464, 191, 133, 28, 0, 170, 188, 90, 69)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PhotoCapturedEventArgs))]
  internal interface IPhotoCapturedEventArgs
  {
    CapturedFrame Frame { get; }

    CapturedFrame Thumbnail { get; }

    TimeSpan CaptureTimeOffset { get; }
  }
}
