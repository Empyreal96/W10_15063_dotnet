// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpStringContentFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Web.Http
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1180999003, 11923, 18667, 142, 97, 25, 103, 120, 120, 229, 127)]
  [ExclusiveTo(typeof (HttpStringContent))]
  internal interface IHttpStringContentFactory
  {
    HttpStringContent CreateFromString(string content);

    HttpStringContent CreateFromStringWithEncoding(
      string content,
      UnicodeEncoding encoding);

    HttpStringContent CreateFromStringWithEncodingAndMediaType(
      string content,
      UnicodeEncoding encoding,
      string mediaType);
  }
}
