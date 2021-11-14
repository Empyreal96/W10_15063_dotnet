// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Core.VariablePhotoCapturedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class VariablePhotoCapturedEventArgs : IVariablePhotoCapturedEventArgs
  {
    public extern CapturedFrame Frame { [MethodImpl] get; }

    public extern TimeSpan CaptureTimeOffset { [MethodImpl] get; }

    public extern IReference<uint> UsedFrameControllerIndex { [MethodImpl] get; }

    public extern CapturedFrameControlValues CapturedFrameControlValues { [MethodImpl] get; }
  }
}
