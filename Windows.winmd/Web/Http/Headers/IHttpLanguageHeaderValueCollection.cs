// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpLanguageHeaderValueCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2663218339, 33305, 17654, 153, 2, 140, 86, 223, 211, 52, 12)]
  [ExclusiveTo(typeof (HttpLanguageHeaderValueCollection))]
  internal interface IHttpLanguageHeaderValueCollection : IVector<Language>, IIterable<Language>
  {
    void ParseAdd(string input);

    bool TryParseAdd(string input);
  }
}
