// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialInteractionSourceEventArgs2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  [Guid(3635721319, 58952, 19794, 171, 73, 224, 210, 39, 25, 159, 99)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (SpatialInteractionSourceEventArgs))]
  internal interface ISpatialInteractionSourceEventArgs2 : ISpatialInteractionSourceEventArgs
  {
    SpatialInteractionPressKind PressKind { get; }
  }
}
