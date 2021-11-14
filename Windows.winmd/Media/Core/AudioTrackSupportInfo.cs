// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.AudioTrackSupportInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AudioTrackSupportInfo : IAudioTrackSupportInfo
  {
    public extern MediaDecoderStatus DecoderStatus { [MethodImpl] get; }

    public extern AudioDecoderDegradation Degradation { [MethodImpl] get; }

    public extern AudioDecoderDegradationReason DegradationReason { [MethodImpl] get; }

    public extern MediaSourceStatus MediaSourceStatus { [MethodImpl] get; }
  }
}
