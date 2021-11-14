// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpLanguageRangeWithQualityHeaderValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1918296322, 128, 19892, 160, 131, 125, 231, 178, 229, 186, 76)]
  [ExclusiveTo(typeof (HttpLanguageRangeWithQualityHeaderValue))]
  internal interface IHttpLanguageRangeWithQualityHeaderValue
  {
    string LanguageRange { get; }

    IReference<double> Quality { get; }
  }
}
