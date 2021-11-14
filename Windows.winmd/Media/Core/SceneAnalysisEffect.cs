// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.SceneAnalysisEffect
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
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class SceneAnalysisEffect : ISceneAnalysisEffect, IMediaExtension
  {
    public extern HighDynamicRangeControl HighDynamicRangeAnalyzer { [MethodImpl] get; }

    public extern TimeSpan DesiredAnalysisInterval { [MethodImpl] set; [MethodImpl] get; }

    public extern event TypedEventHandler<SceneAnalysisEffect, SceneAnalyzedEventArgs> SceneAnalyzed;

    [MethodImpl]
    public extern void SetProperties(IPropertySet configuration);
  }
}
