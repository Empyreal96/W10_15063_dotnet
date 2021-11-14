// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Speech.Recognition.SpeechRecognitionResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Speech.Recognition
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  public sealed class SpeechRecognitionResult : ISpeechRecognitionResult
  {
    public extern string Text { [MethodImpl] get; }

    public extern SpeechRecognitionConfidence TextConfidence { [MethodImpl] get; }

    public extern IMapView<string, SemanticProperty> Semantics { [MethodImpl] get; }

    public extern string RuleName { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<SpeechRecognitionResult> GetAlternates(
      uint maxAlternates);

    public extern SpeechRecognitionResultDetail Details { [MethodImpl] get; }
  }
}
