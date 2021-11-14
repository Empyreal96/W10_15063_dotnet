// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.IDataReaderFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3612506183, 22490, 19989, 145, 76, 6, 128, 102, 153, 160, 152)]
  [ExclusiveTo(typeof (DataReader))]
  internal interface IDataReaderFactory
  {
    DataReader CreateDataReader(IInputStream inputStream);
  }
}
