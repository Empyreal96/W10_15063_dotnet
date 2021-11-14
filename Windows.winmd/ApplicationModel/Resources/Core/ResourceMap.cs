// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.ResourceMap
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ResourceMap : 
    IResourceMap,
    IMapView<string, NamedResource>,
    IIterable<IKeyValuePair<string, NamedResource>>
  {
    public extern Uri Uri { [MethodImpl] get; }

    [Overload("GetValue")]
    [Deprecated("GetValue(string) may be altered or unavailable for releases after Windows 8.1. Instead, use GetValue(string, ResourceContext).", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern ResourceCandidate GetValue(string resource);

    [Overload("GetValueForContext")]
    [MethodImpl]
    public extern ResourceCandidate GetValue(
      string resource,
      ResourceContext context);

    [MethodImpl]
    public extern ResourceMap GetSubtree(string reference);

    [MethodImpl]
    public extern NamedResource Lookup(string key);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool HasKey(string key);

    [MethodImpl]
    public extern void Split(
      out IMapView<string, NamedResource> first,
      out IMapView<string, NamedResource> second);

    [MethodImpl]
    public extern IIterator<IKeyValuePair<string, NamedResource>> First();
  }
}
