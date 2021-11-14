// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.OptionalReferencePhotoCapturedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [GCPressure(amount = GCPressureAmount.High)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class OptionalReferencePhotoCapturedEventArgs : 
    IOptionalReferencePhotoCapturedEventArgs
  {
    public extern CapturedFrame Frame { [MethodImpl] get; }

    public extern object Context { [MethodImpl] get; }
  }
}
