// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Speech.Synthesis.ISpeechBookmarkReachedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Speech.Synthesis
{
  [ExclusiveTo(typeof (SpeechBookmarkReachedEventArgs))]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Guid(3576428023, 61227, 18160, 191, 113, 10, 122, 181, 230, 11, 220)]
  internal interface ISpeechBookmarkReachedEventArgs
  {
    TimeSpan AudioPosition { get; }

    string Bookmark { get; }

    object UserState { [return: Variant] get; }
  }
}
