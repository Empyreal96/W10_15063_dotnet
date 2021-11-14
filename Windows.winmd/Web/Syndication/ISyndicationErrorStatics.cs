// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationErrorStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [Guid(532357985, 17863, 18483, 138, 160, 190, 95, 59, 88, 167, 244)]
  [ExclusiveTo(typeof (SyndicationError))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISyndicationErrorStatics
  {
    SyndicationErrorStatus GetStatus(int hresult);
  }
}
