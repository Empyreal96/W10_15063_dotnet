// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpContentHeaderCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Web.Http.Headers
{
  [ExclusiveTo(typeof (HttpContentHeaderCollection))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1080109636, 18350, 19326, 145, 36, 105, 98, 139, 100, 170, 24)]
  internal interface IHttpContentHeaderCollection : 
    IMap<string, string>,
    IIterable<IKeyValuePair<string, string>>
  {
    HttpContentDispositionHeaderValue ContentDisposition { get; set; }

    HttpContentCodingHeaderValueCollection ContentEncoding { get; }

    HttpLanguageHeaderValueCollection ContentLanguage { get; }

    IReference<ulong> ContentLength { get; set; }

    Uri ContentLocation { get; set; }

    IBuffer ContentMD5 { get; set; }

    HttpContentRangeHeaderValue ContentRange { get; set; }

    HttpMediaTypeHeaderValue ContentType { get; set; }

    IReference<DateTime> Expires { get; set; }

    IReference<DateTime> LastModified { get; set; }

    void Append(string name, string value);

    bool TryAppendWithoutValidation(string name, string value);
  }
}
