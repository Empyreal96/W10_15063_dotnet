// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Compression.IDecompressor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Storage.Compression
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3095658054, 54922, 19595, 173, 160, 78, 232, 19, 252, 82, 131)]
  [ExclusiveTo(typeof (Decompressor))]
  internal interface IDecompressor : IInputStream, IClosable
  {
    IInputStream DetachStream();
  }
}
