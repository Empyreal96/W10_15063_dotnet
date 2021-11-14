// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.FaceDetectionEffectDefinition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Effects;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class FaceDetectionEffectDefinition : 
    IVideoEffectDefinition,
    IFaceDetectionEffectDefinition
  {
    [MethodImpl]
    public extern FaceDetectionEffectDefinition();

    public extern string ActivatableClassId { [MethodImpl] get; }

    public extern IPropertySet Properties { [MethodImpl] get; }

    public extern FaceDetectionMode DetectionMode { [MethodImpl] set; [MethodImpl] get; }

    public extern bool SynchronousDetectionEnabled { [MethodImpl] set; [MethodImpl] get; }
  }
}
