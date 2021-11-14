// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.IResourceLoaderFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources
{
  [Deprecated("ResourceLoader may be altered or unavailable for releases after Windows 8.1. Instead, use GetForCurrentView.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [Guid(3275372035, 27100, 17029, 160, 119, 213, 192, 228, 124, 203, 232)]
  [ExclusiveTo(typeof (ResourceLoader))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IResourceLoaderFactory
  {
    [Deprecated("ResourceLoader may be altered or unavailable for releases after Windows 8.1. Instead, use GetForCurrentView.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    ResourceLoader CreateResourceLoaderByName(string name);
  }
}
