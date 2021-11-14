// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialLocatorPositionalTrackingDeactivatingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class SpatialLocatorPositionalTrackingDeactivatingEventArgs : 
    ISpatialLocatorPositionalTrackingDeactivatingEventArgs
  {
    public extern bool Canceled { [MethodImpl] get; [MethodImpl] set; }
  }
}
