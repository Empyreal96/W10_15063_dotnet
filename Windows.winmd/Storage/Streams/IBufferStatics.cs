// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.IBufferStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  [ExclusiveTo(typeof (Buffer))]
  [Guid(3909215835, 55062, 18266, 169, 10, 175, 114, 41, 177, 231, 65)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBufferStatics
  {
    Buffer CreateCopyFromMemoryBuffer(IMemoryBuffer input);

    MemoryBuffer CreateMemoryBufferOverIBuffer(IBuffer input);
  }
}
