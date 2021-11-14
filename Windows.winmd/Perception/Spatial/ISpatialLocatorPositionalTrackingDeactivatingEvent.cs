// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialLocatorPositionalTrackingDeactivatingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [Guid(3098034275, 58356, 13963, 144, 97, 158, 169, 209, 214, 204, 22)]
  [ExclusiveTo(typeof (SpatialLocatorPositionalTrackingDeactivatingEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISpatialLocatorPositionalTrackingDeactivatingEventArgs
  {
    bool Canceled { get; set; }
  }
}
