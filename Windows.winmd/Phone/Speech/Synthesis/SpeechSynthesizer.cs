// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Speech.Synthesis.SpeechSynthesizer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Speech.Synthesis
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Activatable(65536, "Windows.Phone.PhoneInternalContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SpeechSynthesizer : ISpeechSynthesizer, IClosable
  {
    [MethodImpl]
    public extern SpeechSynthesizer();

    [Overload("SpeakTextAsync")]
    [MethodImpl]
    public extern IAsyncAction SpeakTextAsync(string content);

    [Overload("SpeakTextWithUserStateAsync")]
    [MethodImpl]
    public extern IAsyncAction SpeakTextAsync(string content, [Variant] object userState);

    [Overload("SpeakSsmlAsync")]
    [MethodImpl]
    public extern IAsyncAction SpeakSsmlAsync(string content);

    [Overload("SpeakSsmlWithUserStateAsync")]
    [MethodImpl]
    public extern IAsyncAction SpeakSsmlAsync(string content, [Variant] object userState);

    [Overload("SpeakSsmlFromUriAsync")]
    [MethodImpl]
    public extern IAsyncAction SpeakSsmlFromUriAsync(Uri content);

    [Overload("SpeakSsmlFromUriWithUserStateAsync")]
    [MethodImpl]
    public extern IAsyncAction SpeakSsmlFromUriAsync(Uri content, [Variant] object userState);

    [MethodImpl]
    public extern void CancelAll();

    [MethodImpl]
    public extern void SetVoice(VoiceInformation voiceInformation);

    [MethodImpl]
    public extern VoiceInformation GetVoice();

    public extern event TypedEventHandler<SpeechSynthesizer, SpeechStartedEventArgs> SpeechStarted;

    public extern event TypedEventHandler<SpeechSynthesizer, SpeechBookmarkReachedEventArgs> BookmarkReached;

    [MethodImpl]
    public extern void Close();
  }
}
