// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.ICapturedFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Capture
{
  [ExclusiveTo(typeof (CapturedFrame))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(500358687, 22299, 17624, 142, 128, 160, 138, 21, 120, 118, 110)]
  internal interface ICapturedFrame : 
    IRandomAccessStreamWithContentType,
    IRandomAccessStream,
    IClosable,
    IInputStream,
    IOutputStream,
    IContentTypeProvider
  {
    uint Width { get; }

    uint Height { get; }
  }
}
