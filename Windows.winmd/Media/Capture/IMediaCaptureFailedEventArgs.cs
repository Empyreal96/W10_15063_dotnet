// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureFailedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ExclusiveTo(typeof (MediaCaptureFailedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2164122612, 21700, 17088, 141, 25, 206, 161, 168, 124, 161, 139)]
  internal interface IMediaCaptureFailedEventArgs
  {
    string Message { get; }

    uint Code { get; }
  }
}
