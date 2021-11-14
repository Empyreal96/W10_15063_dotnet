// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.TileOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum TileOptions : uint
  {
    [Deprecated("TileOptions.None may be altered or unavailable for release after Windows Phone 8.1.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] None = 0,
    [Deprecated("TileOptions.ShowNameOnLogo may be altered or unavailable for releases after Windows Phone 8.1. Instead, use SecondaryTile.VisualElements.ShowNameOnSquare150x150Logo.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] ShowNameOnLogo = 1,
    [Deprecated("TileOptions.ShowNameWideOnLogo may be altered or unavailable for releases after Windows Phone 8.1. Instead, use SecondaryTile.VisualElements.ShowNameOnWide310x150Logo.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] ShowNameOnWideLogo = 2,
    [Deprecated("TileOptions.CopyOnDeployment may be altered or unavailable for releases after Windows Phone 8.1. Instead, use SecondaryTile.RoamingEnabled to control roaming behavior.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] CopyOnDeployment = 4,
  }
}
