// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Speech.Recognition.ISpeechRecognizerUISettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Speech.Recognition
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [ExclusiveTo(typeof (SpeechRecognizerUISettings))]
  [Guid(3272574221, 15291, 18606, 131, 28, 255, 136, 175, 64, 62, 91)]
  internal interface ISpeechRecognizerUISettings
  {
    string ListenText { get; set; }

    string ExampleText { get; set; }

    bool ShowConfirmation { get; set; }

    bool ReadoutEnabled { get; set; }
  }
}
