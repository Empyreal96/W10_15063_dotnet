// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpCredentialsHeaderValueStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(2795187174, 52876, 17475, 163, 90, 27, 114, 123, 19, 16, 54)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpCredentialsHeaderValue))]
  internal interface IHttpCredentialsHeaderValueStatics
  {
    HttpCredentialsHeaderValue Parse(string input);

    bool TryParse(
      string input,
      out HttpCredentialsHeaderValue credentialsHeaderValue);
  }
}
