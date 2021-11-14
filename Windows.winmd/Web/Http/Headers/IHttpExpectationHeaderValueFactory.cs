// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpExpectationHeaderValueFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1319269835, 54590, 18536, 136, 86, 30, 33, 165, 3, 13, 192)]
  [ExclusiveTo(typeof (HttpExpectationHeaderValue))]
  internal interface IHttpExpectationHeaderValueFactory
  {
    HttpExpectationHeaderValue CreateFromName(string name);

    HttpExpectationHeaderValue CreateFromNameWithValue(
      string name,
      string value);
  }
}
