// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Speech.Recognition.SpeechRecognizerSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Speech.Recognition
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  public sealed class SpeechRecognizerSettings : ISpeechRecognizerSettings
  {
    public extern TimeSpan InitialSilenceTimeout { [MethodImpl] get; [MethodImpl] set; }

    public extern TimeSpan EndSilenceTimeout { [MethodImpl] get; [MethodImpl] set; }

    public extern TimeSpan BabbleTimeout { [MethodImpl] get; [MethodImpl] set; }
  }
}
