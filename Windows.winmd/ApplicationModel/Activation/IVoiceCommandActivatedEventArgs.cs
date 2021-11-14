// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IVoiceCommandActivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.SpeechRecognition;

namespace Windows.ApplicationModel.Activation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2878528765, 36163, 19942, 151, 117, 32, 112, 75, 88, 27, 0)]
  public interface IVoiceCommandActivatedEventArgs : IActivatedEventArgs
  {
    SpeechRecognitionResult Result { get; }
  }
}
