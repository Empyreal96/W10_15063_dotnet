// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpCredentialsHeaderValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpCredentialsHeaderValue))]
  [Guid(3276587979, 21550, 16759, 166, 199, 182, 116, 206, 25, 63, 191)]
  internal interface IHttpCredentialsHeaderValue
  {
    IVector<HttpNameValueHeaderValue> Parameters { get; }

    string Scheme { get; }

    string Token { get; }
  }
}
