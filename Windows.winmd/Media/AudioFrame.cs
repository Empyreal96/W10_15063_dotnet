// Decompiled with JetBrains decompiler
// Type: Windows.Media.AudioFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IAudioFrameFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class AudioFrame : IAudioFrame, IMediaFrame, IClosable
  {
    [MethodImpl]
    public extern AudioFrame([Range(0, 2147483647)] uint capacity);

    [MethodImpl]
    public extern AudioBuffer LockBuffer(AudioBufferAccessMode mode);

    public extern string Type { [MethodImpl] get; }

    public extern bool IsReadOnly { [MethodImpl] get; }

    public extern IReference<TimeSpan> RelativeTime { [MethodImpl] set; [MethodImpl] get; }

    public extern IReference<TimeSpan> SystemRelativeTime { [MethodImpl] set; [MethodImpl] get; }

    public extern IReference<TimeSpan> Duration { [MethodImpl] set; [MethodImpl] get; }

    public extern bool IsDiscontinuous { [MethodImpl] set; [MethodImpl] get; }

    public extern IPropertySet ExtendedProperties { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();
  }
}
