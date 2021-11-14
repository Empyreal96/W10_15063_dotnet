// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.ProcessVideoFrameContext
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [GCPressure(amount = GCPressureAmount.High)]
  [Threading(ThreadingModel.Both)]
  public sealed class ProcessVideoFrameContext : IProcessVideoFrameContext
  {
    public extern VideoFrame InputFrame { [MethodImpl] get; }

    public extern VideoFrame OutputFrame { [MethodImpl] get; }
  }
}
