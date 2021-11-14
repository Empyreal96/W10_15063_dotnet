// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationNodeFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [Guid(311435656, 19147, 18856, 183, 119, 165, 235, 146, 225, 138, 121)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SyndicationNode))]
  internal interface ISyndicationNodeFactory
  {
    SyndicationNode CreateSyndicationNode(
      string nodeName,
      string nodeNamespace,
      string nodeValue);
  }
}
