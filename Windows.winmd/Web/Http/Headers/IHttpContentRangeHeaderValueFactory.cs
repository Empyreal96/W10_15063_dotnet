// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpContentRangeHeaderValueFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(1062983313, 41020, 17494, 154, 111, 239, 39, 236, 208, 60, 174)]
  [ExclusiveTo(typeof (HttpContentRangeHeaderValue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpContentRangeHeaderValueFactory
  {
    HttpContentRangeHeaderValue CreateFromLength(ulong length);

    HttpContentRangeHeaderValue CreateFromRange(ulong from, ulong to);

    HttpContentRangeHeaderValue CreateFromRangeWithLength(
      ulong from,
      ulong to,
      ulong length);
  }
}
