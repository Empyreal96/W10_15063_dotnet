// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Speech.Synthesis.ISpeechSynthesizer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Speech.Synthesis
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [ExclusiveTo(typeof (SpeechSynthesizer))]
  [Guid(4172921388, 5768, 18188, 172, 25, 67, 105, 16, 164, 142, 164)]
  internal interface ISpeechSynthesizer : IClosable
  {
    [Overload("SpeakTextAsync")]
    IAsyncAction SpeakTextAsync(string content);

    [Overload("SpeakTextWithUserStateAsync")]
    IAsyncAction SpeakTextAsync(string content, [Variant] object userState);

    [Overload("SpeakSsmlAsync")]
    IAsyncAction SpeakSsmlAsync(string content);

    [Overload("SpeakSsmlWithUserStateAsync")]
    IAsyncAction SpeakSsmlAsync(string content, [Variant] object userState);

    [Overload("SpeakSsmlFromUriAsync")]
    IAsyncAction SpeakSsmlFromUriAsync(Uri content);

    [Overload("SpeakSsmlFromUriWithUserStateAsync")]
    IAsyncAction SpeakSsmlFromUriAsync(Uri content, [Variant] object userState);

    void CancelAll();

    void SetVoice(VoiceInformation voiceInformation);

    VoiceInformation GetVoice();

    event TypedEventHandler<SpeechSynthesizer, SpeechStartedEventArgs> SpeechStarted;

    event TypedEventHandler<SpeechSynthesizer, SpeechBookmarkReachedEventArgs> BookmarkReached;
  }
}
