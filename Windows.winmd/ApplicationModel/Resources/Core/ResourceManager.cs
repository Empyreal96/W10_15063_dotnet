// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.ResourceManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.Resources.Core
{
  [Static(typeof (IResourceManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class ResourceManager : IResourceManager, IResourceManager2
  {
    public extern ResourceMap MainResourceMap { [MethodImpl] get; }

    public extern IMapView<string, ResourceMap> AllResourceMaps { [MethodImpl] get; }

    public extern ResourceContext DefaultContext { [Deprecated("DefaultContext may be altered or unavailable for releases after Windows Phone 'OSVersion' (TBD). Instead, use ResourceContext.GetForCurrentView.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    [MethodImpl]
    public extern void LoadPriFiles(IIterable<IStorageFile> files);

    [MethodImpl]
    public extern void UnloadPriFiles(IIterable<IStorageFile> files);

    [MethodImpl]
    public extern IVectorView<NamedResource> GetAllNamedResourcesForPackage(
      string packageName,
      ResourceLayoutInfo resourceLayoutInfo);

    [MethodImpl]
    public extern IVectorView<ResourceMap> GetAllSubtreesForPackage(
      string packageName,
      ResourceLayoutInfo resourceLayoutInfo);

    public static extern ResourceManager Current { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool IsResourceReference(string resourceReference);
  }
}
