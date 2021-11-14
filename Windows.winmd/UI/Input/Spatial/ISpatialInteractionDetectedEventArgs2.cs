// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialInteractionDetectedEventArgs2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  [ExclusiveTo(typeof (SpatialInteractionDetectedEventArgs))]
  [Guid(2066103955, 24339, 16796, 151, 213, 131, 70, 120, 38, 106, 166)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ISpatialInteractionDetectedEventArgs2 : ISpatialInteractionDetectedEventArgs
  {
    SpatialInteractionSource InteractionSource { get; }
  }
}
