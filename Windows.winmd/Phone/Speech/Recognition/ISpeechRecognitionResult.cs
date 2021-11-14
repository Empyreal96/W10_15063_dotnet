// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Speech.Recognition.ISpeechRecognitionResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Speech.Recognition
{
  [Guid(3335981552, 59476, 18967, 146, 11, 38, 158, 146, 208, 236, 252)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [ExclusiveTo(typeof (SpeechRecognitionResult))]
  internal interface ISpeechRecognitionResult
  {
    string Text { get; }

    SpeechRecognitionConfidence TextConfidence { get; }

    IMapView<string, SemanticProperty> Semantics { get; }

    string RuleName { get; }

    IVectorView<SpeechRecognitionResult> GetAlternates(
      uint maxAlternates);

    SpeechRecognitionResultDetail Details { get; }
  }
}
