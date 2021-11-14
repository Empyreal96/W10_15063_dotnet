// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationContent
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [Guid(1178730238, 3669, 16592, 184, 208, 106, 44, 203, 169, 252, 124)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SyndicationContent))]
  internal interface ISyndicationContent : ISyndicationText, ISyndicationNode
  {
    Uri SourceUri { get; set; }
  }
}
