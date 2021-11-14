// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialNavigationCompletedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (SpatialNavigationCompletedEventArgs))]
  [Guid(19824823, 44859, 17090, 158, 65, 186, 170, 14, 114, 31, 58)]
  internal interface ISpatialNavigationCompletedEventArgs
  {
    SpatialInteractionSourceKind InteractionSourceKind { get; }

    Vector3 NormalizedOffset { get; }
  }
}
