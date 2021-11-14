// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.Buffer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  [Muse(Version = 100794368)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IBufferFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IBufferStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class Buffer : IBuffer
  {
    [MethodImpl]
    public extern Buffer([Range(0, 2147483647)] uint capacity);

    public extern uint Capacity { [MethodImpl] get; }

    public extern uint Length { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public static extern Buffer CreateCopyFromMemoryBuffer(IMemoryBuffer input);

    [MethodImpl]
    public static extern MemoryBuffer CreateMemoryBufferOverIBuffer(IBuffer input);
  }
}
