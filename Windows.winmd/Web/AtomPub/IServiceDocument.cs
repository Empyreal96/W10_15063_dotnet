// Decompiled with JetBrains decompiler
// Type: Windows.Web.AtomPub.IServiceDocument
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Web.Syndication;

namespace Windows.Web.AtomPub
{
  [ExclusiveTo(typeof (ServiceDocument))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2340341617, 10931, 19902, 139, 204, 119, 143, 146, 183, 94, 81)]
  internal interface IServiceDocument : ISyndicationNode
  {
    IVectorView<Workspace> Workspaces { get; }
  }
}
