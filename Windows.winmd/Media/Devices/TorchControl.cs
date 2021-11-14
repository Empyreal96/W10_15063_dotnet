// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.TorchControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class TorchControl : ITorchControl
  {
    public extern bool Supported { [MethodImpl] get; }

    public extern bool PowerSupported { [MethodImpl] get; }

    public extern bool Enabled { [MethodImpl] get; [MethodImpl] set; }

    public extern float PowerPercent { [MethodImpl] get; [MethodImpl] set; }
  }
}
