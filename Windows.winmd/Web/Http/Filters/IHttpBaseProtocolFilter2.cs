// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Filters.IHttpBaseProtocolFilter2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Filters
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpBaseProtocolFilter))]
  [Guid(784531475, 37927, 18688, 160, 23, 250, 125, 163, 181, 201, 174)]
  internal interface IHttpBaseProtocolFilter2 : IHttpFilter, IClosable
  {
    HttpVersion MaxVersion { get; set; }
  }
}
