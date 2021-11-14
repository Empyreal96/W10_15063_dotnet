// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechSynthesis.ISpeechSynthesizer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechSynthesis
{
  [ExclusiveTo(typeof (SpeechSynthesizer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3466558582, 38900, 19693, 173, 104, 213, 28, 69, 142, 69, 198)]
  internal interface ISpeechSynthesizer
  {
    [RemoteAsync]
    IAsyncOperation<SpeechSynthesisStream> SynthesizeTextToStreamAsync(
      string text);

    [RemoteAsync]
    IAsyncOperation<SpeechSynthesisStream> SynthesizeSsmlToStreamAsync(
      string Ssml);

    VoiceInformation Voice { set; get; }
  }
}
