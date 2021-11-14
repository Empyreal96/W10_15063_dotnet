// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpContentRangeHeaderValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(81356755, 42230, 18780, 149, 48, 133, 121, 252, 186, 138, 169)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpContentRangeHeaderValue))]
  internal interface IHttpContentRangeHeaderValue
  {
    IReference<ulong> FirstBytePosition { get; }

    IReference<ulong> LastBytePosition { get; }

    IReference<ulong> Length { get; }

    string Unit { get; set; }
  }
}
