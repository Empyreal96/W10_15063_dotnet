// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationCategory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [Guid(2266325615, 3258, 19071, 137, 255, 236, 181, 40, 20, 35, 182)]
  [ExclusiveTo(typeof (SyndicationCategory))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISyndicationCategory : ISyndicationNode
  {
    string Label { get; set; }

    string Scheme { get; set; }

    string Term { get; set; }
  }
}
