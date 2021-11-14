// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialEntityUpdatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [Guid(3848738662, 25211, 17355, 164, 159, 179, 190, 109, 71, 222, 237)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (SpatialEntityUpdatedEventArgs))]
  internal interface ISpatialEntityUpdatedEventArgs
  {
    SpatialEntity Entity { get; }
  }
}
