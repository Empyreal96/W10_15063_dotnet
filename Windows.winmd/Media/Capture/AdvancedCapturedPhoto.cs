// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.AdvancedCapturedPhoto
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Devices;

namespace Windows.Media.Capture
{
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [GCPressure(amount = GCPressureAmount.High)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AdvancedCapturedPhoto : IAdvancedCapturedPhoto, IAdvancedCapturedPhoto2
  {
    public extern CapturedFrame Frame { [MethodImpl] get; }

    public extern AdvancedPhotoMode Mode { [MethodImpl] get; }

    public extern object Context { [MethodImpl] get; }

    public extern IReference<Rect> FrameBoundsRelativeToReferencePhoto { [MethodImpl] get; }
  }
}
