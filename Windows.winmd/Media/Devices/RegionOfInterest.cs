// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.RegionOfInterest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100859904)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class RegionOfInterest : IRegionOfInterest, IRegionOfInterest2
  {
    [MethodImpl]
    public extern RegionOfInterest();

    public extern bool AutoFocusEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AutoWhiteBalanceEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AutoExposureEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern Rect Bounds { [MethodImpl] get; [MethodImpl] set; }

    public extern RegionOfInterestType Type { [MethodImpl] get; [MethodImpl] set; }

    public extern bool BoundsNormalized { [MethodImpl] get; [MethodImpl] set; }

    public extern uint Weight { [MethodImpl] get; [MethodImpl] set; }
  }
}
