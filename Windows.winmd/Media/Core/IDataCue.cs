// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IDataCue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Core
{
  [Guid(2088724333, 8124, 20013, 154, 135, 238, 56, 189, 29, 198, 55)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DataCue))]
  internal interface IDataCue : IMediaCue
  {
    IBuffer Data { set; get; }
  }
}
