// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.IRandomAccessStream
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  [Guid(2421821409, 48211, 4575, 140, 73, 0, 30, 79, 198, 134, 218)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IRandomAccessStream : IClosable, IInputStream, IOutputStream
  {
    ulong Size { get; set; }

    IInputStream GetInputStreamAt(ulong position);

    IOutputStream GetOutputStreamAt(ulong position);

    ulong Position { get; }

    void Seek(ulong position);

    IRandomAccessStream CloneStream();

    bool CanRead { get; }

    bool CanWrite { get; }
  }
}
