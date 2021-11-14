// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechSynthesis.ISpeechSynthesisStream
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.SpeechSynthesis
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2212785811, 9292, 17954, 186, 11, 98, 41, 196, 208, 214, 93)]
  [ExclusiveTo(typeof (SpeechSynthesisStream))]
  internal interface ISpeechSynthesisStream : 
    IRandomAccessStreamWithContentType,
    IRandomAccessStream,
    IClosable,
    IInputStream,
    IOutputStream,
    IContentTypeProvider
  {
    IVectorView<IMediaMarker> Markers { get; }
  }
}
