// Decompiled with JetBrains decompiler
// Type: Windows.Media.AudioBuffer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [GCPressure(amount = GCPressureAmount.Low)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class AudioBuffer : IAudioBuffer, IMemoryBuffer, IClosable
  {
    public extern uint Capacity { [MethodImpl] get; }

    public extern uint Length { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern IMemoryBufferReference CreateReference();

    [MethodImpl]
    public extern void Close();
  }
}
