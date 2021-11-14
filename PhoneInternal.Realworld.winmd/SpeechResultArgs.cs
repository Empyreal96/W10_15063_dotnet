// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Realworld.Speech.SpeechResultArgs
// Assembly: PhoneInternal.Realworld, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: BB230F34-74A2-4E99-8FA1-8CEC24DFDAE5
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Realworld.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Realworld.Speech
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Version(100859904)]
  [Threading(ThreadingModel.Both)]
  public sealed class SpeechResultArgs : ISpeechResultArgs
  {
    public extern string ResultString { [MethodImpl] get; }

    public extern string OriginalSsmlString { [MethodImpl] get; }

    public extern bool IsEndOfFlow { [MethodImpl] get; }

    public extern SpeechScenarios WinningVoiceAgentID { [MethodImpl] get; }

    public extern string SecondaryDisplayTextSmall { [MethodImpl] get; }

    public extern string SecondaryDisplayTextMedium { [MethodImpl] get; }

    public extern string SecondaryDisplayTextLarge { [MethodImpl] get; }
  }
}
