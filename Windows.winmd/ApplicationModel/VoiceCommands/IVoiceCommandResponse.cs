// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.IVoiceCommandResponse
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.VoiceCommands
{
  [Guid(42251022, 35387, 19652, 166, 161, 202, 213, 190, 39, 22, 181)]
  [ExclusiveTo(typeof (VoiceCommandResponse))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVoiceCommandResponse
  {
    VoiceCommandUserMessage Message { get; set; }

    VoiceCommandUserMessage RepeatMessage { get; set; }

    string AppLaunchArgument { get; set; }

    IVector<VoiceCommandContentTile> VoiceCommandContentTiles { get; }
  }
}
