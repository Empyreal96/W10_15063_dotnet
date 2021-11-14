// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechRecognitionCompilationResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  [ExclusiveTo(typeof (SpeechRecognitionCompilationResult))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1082027101, 27335, 19876, 156, 193, 47, 206, 50, 207, 116, 137)]
  internal interface ISpeechRecognitionCompilationResult
  {
    SpeechRecognitionResultStatus Status { get; }
  }
}
