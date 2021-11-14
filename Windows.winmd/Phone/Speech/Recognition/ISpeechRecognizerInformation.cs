// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Speech.Recognition.ISpeechRecognizerInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Speech.Recognition
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [ExclusiveTo(typeof (SpeechRecognizerInformation))]
  [Guid(3179805680, 54243, 17945, 171, 210, 30, 106, 228, 6, 23, 33)]
  internal interface ISpeechRecognizerInformation
  {
    string DisplayName { get; }

    string Id { get; }

    string Language { get; }

    string Description { get; }
  }
}
