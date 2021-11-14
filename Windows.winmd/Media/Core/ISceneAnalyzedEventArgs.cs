// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ISceneAnalyzedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (SceneAnalyzedEventArgs))]
  [Guid(342594952, 10321, 17892, 173, 85, 68, 207, 141, 248, 219, 77)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISceneAnalyzedEventArgs
  {
    SceneAnalysisEffectFrame ResultFrame { get; }
  }
}
