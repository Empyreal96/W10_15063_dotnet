// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechContinuousRecognitionCompletedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  [Guid(3822086587, 58124, 24088, 66, 75, 127, 190, 129, 248, 251, 208)]
  [ExclusiveTo(typeof (SpeechContinuousRecognitionCompletedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISpeechContinuousRecognitionCompletedEventArgs
  {
    SpeechRecognitionResultStatus Status { get; }
  }
}
