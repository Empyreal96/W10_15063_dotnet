// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialInteractionSourceState2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  [ExclusiveTo(typeof (SpatialInteractionSourceState))]
  [Guid(1173803197, 6003, 18734, 155, 163, 138, 193, 203, 231, 124, 8)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ISpatialInteractionSourceState2 : ISpatialInteractionSourceState
  {
    bool IsSelectPressed { get; }

    bool IsMenuPressed { get; }

    bool IsGrasped { get; }

    double SelectPressedValue { get; }

    SpatialInteractionControllerProperties ControllerProperties { get; }
  }
}
