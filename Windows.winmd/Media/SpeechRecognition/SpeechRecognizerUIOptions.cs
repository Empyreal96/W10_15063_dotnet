// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.SpeechRecognizerUIOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SpeechRecognizerUIOptions : ISpeechRecognizerUIOptions
  {
    public extern string ExampleText { [MethodImpl] get; [MethodImpl] set; }

    public extern string AudiblePrompt { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsReadBackEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool ShowConfirmation { [MethodImpl] get; [MethodImpl] set; }
  }
}
