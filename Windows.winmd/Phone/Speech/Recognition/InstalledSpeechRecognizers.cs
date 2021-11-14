// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Speech.Recognition.InstalledSpeechRecognizers
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Speech.Recognition
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IInstalledSpeechRecognizersStatic), 65536, "Windows.Phone.PhoneInternalContract")]
  public static class InstalledSpeechRecognizers
  {
    public static extern IVectorView<SpeechRecognizerInformation> All { [MethodImpl] get; }

    public static extern SpeechRecognizerInformation Default { [MethodImpl] get; }
  }
}
