// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpDateOrDeltaHeaderValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ExclusiveTo(typeof (HttpDateOrDeltaHeaderValue))]
  [Guid(3942427242, 50396, 18914, 162, 125, 4, 58, 223, 88, 103, 163)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpDateOrDeltaHeaderValue
  {
    IReference<DateTime> Date { get; }

    IReference<TimeSpan> Delta { get; }
  }
}
