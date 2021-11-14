// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialEntityAddedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [ExclusiveTo(typeof (SpatialEntityAddedEventArgs))]
  [Guid(2744644763, 5482, 18183, 172, 44, 211, 29, 87, 14, 211, 153)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ISpatialEntityAddedEventArgs
  {
    SpatialEntity Entity { get; }
  }
}
