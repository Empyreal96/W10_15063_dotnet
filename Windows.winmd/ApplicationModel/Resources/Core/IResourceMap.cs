// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.IResourceMap
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources.Core
{
  [ExclusiveTo(typeof (ResourceMap))]
  [Guid(1915242532, 56204, 17144, 176, 140, 83, 255, 53, 125, 173, 130)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IResourceMap : 
    IMapView<string, NamedResource>,
    IIterable<IKeyValuePair<string, NamedResource>>
  {
    Uri Uri { get; }

    [Deprecated("GetValue(string) may be altered or unavailable for releases after Windows 8.1. Instead, use GetValue(string, ResourceContext).", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [Overload("GetValue")]
    ResourceCandidate GetValue(string resource);

    [Overload("GetValueForContext")]
    ResourceCandidate GetValue(string resource, ResourceContext context);

    ResourceMap GetSubtree(string reference);
  }
}
