// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialPointerPose2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2636131095, 38222, 19980, 150, 209, 182, 121, 11, 111, 194, 253)]
  [ExclusiveTo(typeof (SpatialPointerPose))]
  internal interface ISpatialPointerPose2 : ISpatialPointerPose
  {
    SpatialPointerInteractionSourcePose TryGetInteractionSourcePose(
      SpatialInteractionSource source);
  }
}
