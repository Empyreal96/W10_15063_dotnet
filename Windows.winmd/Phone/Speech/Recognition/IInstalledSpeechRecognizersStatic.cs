// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Speech.Recognition.IInstalledSpeechRecognizersStatic
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Speech.Recognition
{
  [ExclusiveTo(typeof (InstalledSpeechRecognizers))]
  [Guid(2477471583, 24972, 17868, 179, 179, 128, 95, 34, 250, 40, 51)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  internal interface IInstalledSpeechRecognizersStatic
  {
    IVectorView<SpeechRecognizerInformation> All { get; }

    SpeechRecognizerInformation Default { get; }
  }
}
