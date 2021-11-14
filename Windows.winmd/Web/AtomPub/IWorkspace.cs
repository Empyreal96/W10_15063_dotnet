// Decompiled with JetBrains decompiler
// Type: Windows.Web.AtomPub.IWorkspace
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Web.Syndication;

namespace Windows.Web.AtomPub
{
  [ExclusiveTo(typeof (Workspace))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3021841979, 42168, 16438, 137, 197, 131, 195, 18, 102, 186, 73)]
  internal interface IWorkspace : ISyndicationNode
  {
    ISyndicationText Title { get; }

    IVectorView<ResourceCollection> Collections { get; }
  }
}
