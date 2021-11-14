// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialHoldCanceledEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (SpatialHoldCanceledEventArgs))]
  [Guid(1576842855, 19626, 16531, 140, 53, 182, 1, 168, 57, 243, 27)]
  internal interface ISpatialHoldCanceledEventArgs
  {
    SpatialInteractionSourceKind InteractionSourceKind { get; }
  }
}
