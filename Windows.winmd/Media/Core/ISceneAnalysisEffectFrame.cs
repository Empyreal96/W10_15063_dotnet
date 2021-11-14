// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ISceneAnalysisEffectFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Capture;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (SceneAnalysisEffectFrame))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3635482188, 32729, 17121, 133, 235, 101, 114, 194, 151, 201, 135)]
  internal interface ISceneAnalysisEffectFrame : IMediaFrame, IClosable
  {
    CapturedFrameControlValues FrameControlValues { get; }

    HighDynamicRangeOutput HighDynamicRange { get; }
  }
}
