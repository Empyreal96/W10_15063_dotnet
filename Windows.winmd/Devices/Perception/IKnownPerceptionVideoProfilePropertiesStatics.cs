// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IKnownPerceptionVideoProfilePropertiesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  [Guid(2399724263, 23158, 17379, 161, 58, 218, 61, 145, 169, 239, 152)]
  [ExclusiveTo(typeof (KnownPerceptionVideoProfileProperties))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("KnownPerceptionVideoProfileProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  internal interface IKnownPerceptionVideoProfilePropertiesStatics
  {
    string BitmapPixelFormat { [Deprecated("KnownPerceptionVideoProfileProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    string BitmapAlphaMode { [Deprecated("KnownPerceptionVideoProfileProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    string Width { [Deprecated("KnownPerceptionVideoProfileProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    string Height { [Deprecated("KnownPerceptionVideoProfileProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    string FrameDuration { [Deprecated("KnownPerceptionVideoProfileProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
