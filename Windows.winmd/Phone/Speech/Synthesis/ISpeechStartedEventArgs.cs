// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Speech.Synthesis.ISpeechStartedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Speech.Synthesis
{
  [Guid(205853154, 23111, 19309, 159, 168, 133, 132, 13, 166, 255, 112)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [ExclusiveTo(typeof (SpeechStartedEventArgs))]
  internal interface ISpeechStartedEventArgs
  {
    object UserState { [return: Variant] get; }
  }
}
