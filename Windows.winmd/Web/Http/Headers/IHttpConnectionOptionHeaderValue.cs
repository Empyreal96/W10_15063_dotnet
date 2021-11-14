// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpConnectionOptionHeaderValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(3410686586, 20112, 17899, 141, 205, 253, 20, 8, 244, 196, 79)]
  [ExclusiveTo(typeof (HttpConnectionOptionHeaderValue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpConnectionOptionHeaderValue
  {
    string Token { get; }
  }
}
