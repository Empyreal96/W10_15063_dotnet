// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Realworld.Speech.ISpeechResultArgs
// Assembly: PhoneInternal.Realworld, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: BB230F34-74A2-4E99-8FA1-8CEC24DFDAE5
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Realworld.winmd

using Windows.Foundation.Metadata;

namespace PhoneInternal.Realworld.Speech
{
  [Guid(2931319931, 35642, 19489, 161, 221, 14, 132, 195, 97, 132, 203)]
  [ExclusiveTo(typeof (SpeechResultArgs))]
  [Version(100859904)]
  internal interface ISpeechResultArgs
  {
    string ResultString { get; }

    string OriginalSsmlString { get; }

    bool IsEndOfFlow { get; }

    SpeechScenarios WinningVoiceAgentID { get; }

    string SecondaryDisplayTextSmall { get; }

    string SecondaryDisplayTextMedium { get; }

    string SecondaryDisplayTextLarge { get; }
  }
}
