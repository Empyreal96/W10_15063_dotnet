// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialAnchor2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [Guid(3977758984, 42645, 19702, 146, 253, 151, 38, 59, 167, 16, 71)]
  [ExclusiveTo(typeof (SpatialAnchor))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface ISpatialAnchor2
  {
    bool RemovedByUser { get; }
  }
}
