// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechRecognizerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.Media.SpeechRecognition
{
  [Guid(1623492829, 32696, 16435, 172, 112, 208, 70, 246, 72, 24, 225)]
  [ExclusiveTo(typeof (SpeechRecognizer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISpeechRecognizerFactory
  {
    SpeechRecognizer Create(Language language);
  }
}
