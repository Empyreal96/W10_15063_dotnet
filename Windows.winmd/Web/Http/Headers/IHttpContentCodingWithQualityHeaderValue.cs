// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpContentCodingWithQualityHeaderValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ExclusiveTo(typeof (HttpContentCodingWithQualityHeaderValue))]
  [Guid(2488474837, 35603, 19827, 134, 81, 247, 107, 56, 248, 132, 149)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpContentCodingWithQualityHeaderValue
  {
    string ContentCoding { get; }

    IReference<double> Quality { get; }
  }
}
