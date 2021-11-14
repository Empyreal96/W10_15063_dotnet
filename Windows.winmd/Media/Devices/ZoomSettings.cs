// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.ZoomSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ZoomSettings : IZoomSettings
  {
    [MethodImpl]
    public extern ZoomSettings();

    public extern ZoomTransitionMode Mode { [MethodImpl] get; [MethodImpl] set; }

    public extern float Value { [MethodImpl] get; [MethodImpl] set; }
  }
}
