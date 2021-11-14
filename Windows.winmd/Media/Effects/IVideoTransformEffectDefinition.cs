// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IVideoTransformEffectDefinition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;
using Windows.Media.Transcoding;
using Windows.UI;

namespace Windows.Media.Effects
{
  [ExclusiveTo(typeof (VideoTransformEffectDefinition))]
  [Guid(2523183978, 7846, 19110, 128, 116, 171, 232, 133, 30, 202, 226)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVideoTransformEffectDefinition : IVideoEffectDefinition
  {
    Color PaddingColor { get; set; }

    Size OutputSize { get; set; }

    Rect CropRectangle { get; set; }

    MediaRotation Rotation { get; set; }

    MediaMirroringOptions Mirror { get; set; }

    MediaVideoProcessingAlgorithm ProcessingAlgorithm { set; get; }
  }
}
