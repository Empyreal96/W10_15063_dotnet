// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.IResourceManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.Resources.Core
{
  [Guid(4148484475, 39304, 17659, 171, 214, 83, 120, 132, 76, 250, 139)]
  [ExclusiveTo(typeof (ResourceManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IResourceManager
  {
    ResourceMap MainResourceMap { get; }

    IMapView<string, ResourceMap> AllResourceMaps { get; }

    ResourceContext DefaultContext { [Deprecated("DefaultContext may be altered or unavailable for releases after Windows Phone 'OSVersion' (TBD). Instead, use ResourceContext.GetForCurrentView.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    void LoadPriFiles(IIterable<IStorageFile> files);

    void UnloadPriFiles(IIterable<IStorageFile> files);
  }
}
