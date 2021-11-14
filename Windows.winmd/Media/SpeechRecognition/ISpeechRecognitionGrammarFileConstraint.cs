// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechRecognitionGrammarFileConstraint
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Media.SpeechRecognition
{
  [Guid(3036879503, 34250, 20388, 177, 26, 71, 79, 196, 27, 56, 53)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SpeechRecognitionGrammarFileConstraint))]
  internal interface ISpeechRecognitionGrammarFileConstraint : ISpeechRecognitionConstraint
  {
    StorageFile GrammarFile { get; }
  }
}
