// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.IBufferFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  [Guid(1907331405, 49423, 18507, 188, 80, 20, 188, 98, 59, 58, 39)]
  [ExclusiveTo(typeof (Buffer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBufferFactory
  {
    Buffer Create([Range(0, 2147483647)] uint capacity);
  }
}
