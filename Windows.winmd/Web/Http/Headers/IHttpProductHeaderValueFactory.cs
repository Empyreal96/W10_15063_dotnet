// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpProductHeaderValueFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1629136117, 33468, 17147, 151, 123, 220, 0, 83, 110, 94, 134)]
  [ExclusiveTo(typeof (HttpProductHeaderValue))]
  internal interface IHttpProductHeaderValueFactory
  {
    HttpProductHeaderValue CreateFromName(string productName);

    HttpProductHeaderValue CreateFromNameWithVersion(
      string productName,
      string productVersion);
  }
}
