﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechRecognitionGrammarFileConstraintFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Media.SpeechRecognition
{
  [Guid(1034383595, 50297, 19495, 159, 25, 137, 151, 78, 243, 146, 209)]
  [ExclusiveTo(typeof (SpeechRecognitionGrammarFileConstraint))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISpeechRecognitionGrammarFileConstraintFactory
  {
    SpeechRecognitionGrammarFileConstraint Create(
      StorageFile file);

    SpeechRecognitionGrammarFileConstraint CreateWithTag(
      StorageFile file,
      string tag);
  }
}
