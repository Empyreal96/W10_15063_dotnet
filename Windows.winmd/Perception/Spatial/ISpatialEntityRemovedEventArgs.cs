// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialEntityRemovedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [Guid(2440304640, 21357, 20127, 171, 246, 65, 91, 84, 68, 214, 81)]
  [ExclusiveTo(typeof (SpatialEntityRemovedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ISpatialEntityRemovedEventArgs
  {
    SpatialEntity Entity { get; }
  }
}
