// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechSynthesis.SpeechSynthesizer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechSynthesis
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IInstalledVoicesStatic), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SpeechSynthesizer : ISpeechSynthesizer, IClosable, ISpeechSynthesizer2
  {
    [MethodImpl]
    public extern SpeechSynthesizer();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SpeechSynthesisStream> SynthesizeTextToStreamAsync(
      string text);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SpeechSynthesisStream> SynthesizeSsmlToStreamAsync(
      string Ssml);

    public extern VoiceInformation Voice { [MethodImpl] set; [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    public extern SpeechSynthesizerOptions Options { [MethodImpl] get; }

    public static extern IVectorView<VoiceInformation> AllVoices { [MethodImpl] get; }

    public static extern VoiceInformation DefaultVoice { [MethodImpl] get; }
  }
}
