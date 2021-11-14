// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.IResourceManager2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources.Core
{
  [Guid(2640772716, 42199, 19491, 158, 133, 103, 95, 48, 76, 37, 45)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ResourceManager))]
  internal interface IResourceManager2
  {
    IVectorView<NamedResource> GetAllNamedResourcesForPackage(
      string packageName,
      ResourceLayoutInfo resourceLayoutInfo);

    IVectorView<ResourceMap> GetAllSubtreesForPackage(
      string packageName,
      ResourceLayoutInfo resourceLayoutInfo);
  }
}
