// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechSynthesis.ISpeechSynthesizer2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechSynthesis
{
  [Guid(2814766258, 17209, 19818, 187, 248, 199, 164, 241, 84, 76, 46)]
  [ExclusiveTo(typeof (SpeechSynthesizer))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ISpeechSynthesizer2
  {
    SpeechSynthesizerOptions Options { get; }
  }
}
