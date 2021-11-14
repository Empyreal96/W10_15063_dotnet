// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.VideoTransformEffectDefinition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;
using Windows.Media.Transcoding;
using Windows.UI;

namespace Windows.Media.Effects
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class VideoTransformEffectDefinition : 
    IVideoEffectDefinition,
    IVideoTransformEffectDefinition
  {
    [MethodImpl]
    public extern VideoTransformEffectDefinition();

    public extern string ActivatableClassId { [MethodImpl] get; }

    public extern IPropertySet Properties { [MethodImpl] get; }

    public extern Color PaddingColor { [MethodImpl] get; [MethodImpl] set; }

    public extern Size OutputSize { [MethodImpl] get; [MethodImpl] set; }

    public extern Rect CropRectangle { [MethodImpl] get; [MethodImpl] set; }

    public extern MediaRotation Rotation { [MethodImpl] get; [MethodImpl] set; }

    public extern MediaMirroringOptions Mirror { [MethodImpl] get; [MethodImpl] set; }

    public extern MediaVideoProcessingAlgorithm ProcessingAlgorithm { [MethodImpl] set; [MethodImpl] get; }
  }
}
