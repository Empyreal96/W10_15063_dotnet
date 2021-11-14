// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpMultipartContentFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpMultipartContent))]
  [Guid(2125737570, 546, 20256, 179, 114, 71, 213, 219, 93, 51, 180)]
  internal interface IHttpMultipartContentFactory
  {
    HttpMultipartContent CreateWithSubtype(string subtype);

    HttpMultipartContent CreateWithSubtypeAndBoundary(
      string subtype,
      string boundary);
  }
}
