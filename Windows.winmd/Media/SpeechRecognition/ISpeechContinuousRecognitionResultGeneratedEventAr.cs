// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechContinuousRecognitionResultGeneratedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  [ExclusiveTo(typeof (SpeechContinuousRecognitionResultGeneratedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(420027934, 28286, 23110, 64, 251, 118, 89, 79, 120, 101, 4)]
  internal interface ISpeechContinuousRecognitionResultGeneratedEventArgs
  {
    SpeechRecognitionResult Result { get; }
  }
}
