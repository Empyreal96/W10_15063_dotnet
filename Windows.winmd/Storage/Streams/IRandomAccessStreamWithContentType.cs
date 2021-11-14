// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.IRandomAccessStreamWithContentType
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3424995367, 19261, 17295, 146, 50, 16, 199, 107, 199, 224, 56)]
  public interface IRandomAccessStreamWithContentType : 
    IRandomAccessStream,
    IClosable,
    IInputStream,
    IOutputStream,
    IContentTypeProvider
  {
  }
}
