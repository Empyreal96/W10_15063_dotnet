// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.VoiceCommandResponse
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.VoiceCommands
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IVoiceCommandResponseStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VoiceCommandResponse : IVoiceCommandResponse
  {
    public extern VoiceCommandUserMessage Message { [MethodImpl] get; [MethodImpl] set; }

    public extern VoiceCommandUserMessage RepeatMessage { [MethodImpl] get; [MethodImpl] set; }

    public extern string AppLaunchArgument { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<VoiceCommandContentTile> VoiceCommandContentTiles { [MethodImpl] get; }

    public static extern uint MaxSupportedVoiceCommandContentTiles { [MethodImpl] get; }

    [Overload("CreateResponse")]
    [MethodImpl]
    public static extern VoiceCommandResponse CreateResponse(
      VoiceCommandUserMessage userMessage);

    [Overload("CreateResponseWithTiles")]
    [MethodImpl]
    public static extern VoiceCommandResponse CreateResponse(
      VoiceCommandUserMessage message,
      IIterable<VoiceCommandContentTile> contentTiles);

    [Overload("CreateResponseForPrompt")]
    [MethodImpl]
    public static extern VoiceCommandResponse CreateResponseForPrompt(
      VoiceCommandUserMessage message,
      VoiceCommandUserMessage repeatMessage);

    [Overload("CreateResponseForPromptWithTiles")]
    [MethodImpl]
    public static extern VoiceCommandResponse CreateResponseForPrompt(
      VoiceCommandUserMessage message,
      VoiceCommandUserMessage repeatMessage,
      IIterable<VoiceCommandContentTile> contentTiles);
  }
}
