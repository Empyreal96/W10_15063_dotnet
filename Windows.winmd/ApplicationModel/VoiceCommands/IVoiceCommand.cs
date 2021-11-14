// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.IVoiceCommand
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.SpeechRecognition;

namespace Windows.ApplicationModel.VoiceCommands
{
  [ExclusiveTo(typeof (VoiceCommand))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2473546355, 60546, 17062, 165, 92, 210, 215, 158, 198, 249, 32)]
  internal interface IVoiceCommand
  {
    string CommandName { get; }

    IMapView<string, IVectorView<string>> Properties { get; }

    SpeechRecognitionResult SpeechRecognitionResult { get; }
  }
}
