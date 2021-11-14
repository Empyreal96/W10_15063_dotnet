// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ISceneAnalysisEffect
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(3226182425, 51777, 18451, 191, 253, 123, 8, 176, 237, 37, 87)]
  [ExclusiveTo(typeof (SceneAnalysisEffect))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISceneAnalysisEffect : IMediaExtension
  {
    HighDynamicRangeControl HighDynamicRangeAnalyzer { get; }

    TimeSpan DesiredAnalysisInterval { set; get; }

    event TypedEventHandler<SceneAnalysisEffect, SceneAnalyzedEventArgs> SceneAnalyzed;
  }
}
