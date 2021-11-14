// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpFormUrlEncodedContentFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  [Guid(1139807116, 12147, 17154, 181, 243, 234, 233, 35, 138, 94, 1)]
  [ExclusiveTo(typeof (HttpFormUrlEncodedContent))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpFormUrlEncodedContentFactory
  {
    HttpFormUrlEncodedContent Create(
      IIterable<IKeyValuePair<string, string>> content);
  }
}
