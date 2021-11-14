// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.IDataWriterFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DataWriter))]
  [Guid(864839618, 35716, 19499, 156, 80, 123, 135, 103, 132, 122, 31)]
  internal interface IDataWriterFactory
  {
    DataWriter CreateDataWriter(IOutputStream outputStream);
  }
}
