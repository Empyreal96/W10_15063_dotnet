// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.IVoiceCommandResponseStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.VoiceCommands
{
  [Guid(691206163, 3387, 18930, 150, 221, 98, 80, 25, 189, 59, 93)]
  [ExclusiveTo(typeof (VoiceCommandResponse))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVoiceCommandResponseStatics
  {
    uint MaxSupportedVoiceCommandContentTiles { get; }

    [Overload("CreateResponse")]
    VoiceCommandResponse CreateResponse(VoiceCommandUserMessage userMessage);

    [Overload("CreateResponseWithTiles")]
    VoiceCommandResponse CreateResponse(
      VoiceCommandUserMessage message,
      IIterable<VoiceCommandContentTile> contentTiles);

    [Overload("CreateResponseForPrompt")]
    VoiceCommandResponse CreateResponseForPrompt(
      VoiceCommandUserMessage message,
      VoiceCommandUserMessage repeatMessage);

    [Overload("CreateResponseForPromptWithTiles")]
    VoiceCommandResponse CreateResponseForPrompt(
      VoiceCommandUserMessage message,
      VoiceCommandUserMessage repeatMessage,
      IIterable<VoiceCommandContentTile> contentTiles);
  }
}
