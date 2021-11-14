// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.FaceDetectionEffect
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class FaceDetectionEffect : IFaceDetectionEffect, IMediaExtension
  {
    public extern bool Enabled { [MethodImpl] set; [MethodImpl] get; }

    public extern TimeSpan DesiredDetectionInterval { [MethodImpl] set; [MethodImpl] get; }

    public extern event TypedEventHandler<FaceDetectionEffect, FaceDetectedEventArgs> FaceDetected;

    [MethodImpl]
    public extern void SetProperties(IPropertySet configuration);
  }
}
