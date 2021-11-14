// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationLinkFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SyndicationLink))]
  [Guid(1591239636, 21813, 18604, 152, 212, 193, 144, 153, 80, 128, 179)]
  internal interface ISyndicationLinkFactory
  {
    SyndicationLink CreateSyndicationLink(Uri uri);

    SyndicationLink CreateSyndicationLinkEx(
      Uri uri,
      string relationship,
      string title,
      string mediaType,
      uint length);
  }
}
