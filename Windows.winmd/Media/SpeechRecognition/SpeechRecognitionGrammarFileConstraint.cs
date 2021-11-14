// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.SpeechRecognitionGrammarFileConstraint
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Media.SpeechRecognition
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (ISpeechRecognitionGrammarFileConstraintFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SpeechRecognitionGrammarFileConstraint : 
    ISpeechRecognitionGrammarFileConstraint,
    ISpeechRecognitionConstraint
  {
    [MethodImpl]
    public extern SpeechRecognitionGrammarFileConstraint(StorageFile file);

    [MethodImpl]
    public extern SpeechRecognitionGrammarFileConstraint(StorageFile file, string tag);

    public extern StorageFile GrammarFile { [MethodImpl] get; }

    public extern bool IsEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern string Tag { [MethodImpl] get; [MethodImpl] set; }

    public extern SpeechRecognitionConstraintType Type { [MethodImpl] get; }

    public extern SpeechRecognitionConstraintProbability Probability { [MethodImpl] get; [MethodImpl] set; }
  }
}
