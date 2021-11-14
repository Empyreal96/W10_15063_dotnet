// Decompiled with JetBrains decompiler
// Type: Windows.Web.AtomPub.IResourceCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Web.Syndication;

namespace Windows.Web.AtomPub
{
  [Guid(2136987145, 48264, 16852, 136, 250, 61, 230, 112, 77, 66, 142)]
  [ExclusiveTo(typeof (ResourceCollection))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IResourceCollection : ISyndicationNode
  {
    ISyndicationText Title { get; }

    Uri Uri { get; }

    IVectorView<SyndicationCategory> Categories { get; }

    IVectorView<string> Accepts { get; }
  }
}
