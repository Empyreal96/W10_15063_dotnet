// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.NamedResource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources.Core
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class NamedResource : INamedResource
  {
    public extern Uri Uri { [MethodImpl] get; }

    public extern IVectorView<ResourceCandidate> Candidates { [MethodImpl] get; }

    [Deprecated("Resolve may be altered or unavailable for releases after Windows 8.1. Instead, use Resolve(ResourceContext).", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [Overload("Resolve")]
    [MethodImpl]
    public extern ResourceCandidate Resolve();

    [Overload("ResolveForContext")]
    [MethodImpl]
    public extern ResourceCandidate Resolve(ResourceContext resourceContext);

    [Overload("ResolveAll")]
    [Deprecated("ResolveAll may be altered or unavailable for releases after Windows 8.1. Instead, use ResolveAll(ResourceContext).", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IVectorView<ResourceCandidate> ResolveAll();

    [Overload("ResolveAllForContext")]
    [MethodImpl]
    public extern IVectorView<ResourceCandidate> ResolveAll(
      ResourceContext resourceContext);
  }
}
