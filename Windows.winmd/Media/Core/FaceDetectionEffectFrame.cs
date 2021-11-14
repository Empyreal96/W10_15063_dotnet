// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.FaceDetectionEffectFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.FaceAnalysis;

namespace Windows.Media.Core
{
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class FaceDetectionEffectFrame : IFaceDetectionEffectFrame, IMediaFrame, IClosable
  {
    public extern IVectorView<DetectedFace> DetectedFaces { [MethodImpl] get; }

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
