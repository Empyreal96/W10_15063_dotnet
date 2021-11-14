// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpStreamContentFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Web.Http
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpStreamContent))]
  [Guid(4091956637, 63269, 16510, 148, 47, 14, 218, 24, 152, 9, 244)]
  internal interface IHttpStreamContentFactory
  {
    HttpStreamContent CreateFromInputStream(IInputStream content);
  }
}
