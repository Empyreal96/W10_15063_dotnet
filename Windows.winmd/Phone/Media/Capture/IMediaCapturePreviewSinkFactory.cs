// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Media.Capture.IMediaCapturePreviewSinkFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Media.Capture
{
  [Guid(221681064, 48221, 19768, 161, 222, 4, 167, 83, 211, 123, 237)]
  [ExclusiveTo(typeof (MediaCapturePreviewSink))]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  internal interface IMediaCapturePreviewSinkFactory : IClosable
  {
    MediaCapturePreviewSink CreateInstance(string connectionPort);
  }
}
