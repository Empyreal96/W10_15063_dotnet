// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.INamedResource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources.Core
{
  [Guid(479773209, 2835, 16960, 137, 165, 212, 149, 220, 24, 154, 0)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (NamedResource))]
  internal interface INamedResource
  {
    Uri Uri { get; }

    IVectorView<ResourceCandidate> Candidates { get; }

    [Overload("Resolve")]
    [Deprecated("Resolve may be altered or unavailable for releases after Windows 8.1. Instead, use Resolve(ResourceContext).", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    ResourceCandidate Resolve();

    [Overload("ResolveForContext")]
    ResourceCandidate Resolve(ResourceContext resourceContext);

    [Deprecated("ResolveAll may be altered or unavailable for releases after Windows 8.1. Instead, use ResolveAll(ResourceContext).", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [Overload("ResolveAll")]
    IVectorView<ResourceCandidate> ResolveAll();

    [Overload("ResolveAllForContext")]
    IVectorView<ResourceCandidate> ResolveAll(
      ResourceContext resourceContext);
  }
}
