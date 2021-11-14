// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechSynthesis.ISpeechSynthesizerOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechSynthesis
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2699180145, 52285, 17353, 145, 177, 238, 24, 83, 36, 216, 61)]
  [ExclusiveTo(typeof (SpeechSynthesizerOptions))]
  internal interface ISpeechSynthesizerOptions
  {
    bool IncludeWordBoundaryMetadata { get; set; }

    bool IncludeSentenceBoundaryMetadata { get; set; }
  }
}
