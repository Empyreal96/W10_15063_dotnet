// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechRecognizerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.Media.SpeechRecognition
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SpeechRecognizer))]
  [Guid(2275630764, 42972, 19211, 188, 201, 36, 244, 124, 11, 126, 191)]
  internal interface ISpeechRecognizerStatics
  {
    Language SystemSpeechLanguage { get; }

    IVectorView<Language> SupportedTopicLanguages { get; }

    IVectorView<Language> SupportedGrammarLanguages { get; }
  }
}
