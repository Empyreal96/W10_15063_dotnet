// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationAttributeFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [ExclusiveTo(typeof (SyndicationAttribute))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1649350041, 60734, 16911, 190, 134, 100, 4, 20, 136, 110, 75)]
  internal interface ISyndicationAttributeFactory
  {
    SyndicationAttribute CreateSyndicationAttribute(
      string attributeName,
      string attributeNamespace,
      string attributeValue);
  }
}
