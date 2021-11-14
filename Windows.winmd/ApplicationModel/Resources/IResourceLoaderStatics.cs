// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.IResourceLoaderStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources
{
  [ExclusiveTo(typeof (ResourceLoader))]
  [Guid(3212279009, 6600, 18882, 149, 60, 71, 233, 34, 123, 51, 78)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("GetStringForReference may be altered or unavailable for releases after Windows Phone 'OSVersion' (TBD). Instead, use GetStringForUri.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  internal interface IResourceLoaderStatics
  {
    [Deprecated("GetStringForReference may be altered or unavailable for releases after Windows Phone 'OSVersion' (TBD). Instead, use GetStringForUri.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    string GetStringForReference(Uri uri);
  }
}
