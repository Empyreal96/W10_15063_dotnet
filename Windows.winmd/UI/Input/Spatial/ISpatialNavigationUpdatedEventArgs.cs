// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialNavigationUpdatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Spatial
{
  [Guid(2607890391, 33693, 19060, 135, 50, 69, 70, 111, 192, 68, 181)]
  [ExclusiveTo(typeof (SpatialNavigationUpdatedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISpatialNavigationUpdatedEventArgs
  {
    SpatialInteractionSourceKind InteractionSourceKind { get; }

    Vector3 NormalizedOffset { get; }
  }
}
