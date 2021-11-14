// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationFeedFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [ExclusiveTo(typeof (SyndicationFeed))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(591864370, 35817, 18615, 137, 52, 98, 5, 19, 29, 147, 87)]
  internal interface ISyndicationFeedFactory
  {
    SyndicationFeed CreateSyndicationFeed(string title, string subtitle, Uri uri);
  }
}
