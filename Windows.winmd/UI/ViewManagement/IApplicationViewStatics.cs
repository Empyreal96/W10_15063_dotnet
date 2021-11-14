// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationViewStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [Deprecated("ApplicationView static methods may be altered or unavailable for releases after Windows 8.1. Instead, use ApplicationView.GetForCurrentView to get an instance of ApplicationView.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (ApplicationView))]
  [Guid(17457926, 50227, 17637, 169, 242, 189, 132, 212, 3, 10, 149)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IApplicationViewStatics
  {
    ApplicationViewState Value { [Deprecated("Value may be altered or unavailable for releases after Windows 8.1. Instead, query for window layout sizes directly.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    [Deprecated("TryUnsnap may be altered or unavailable for releases after Windows 8.1. Apps can be continuously resized, but cannot be snapped, starting in Windows 8.1.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    bool TryUnsnap();
  }
}
