// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.IVoiceCommandUserMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.VoiceCommands
{
  [ExclusiveTo(typeof (VoiceCommandUserMessage))]
  [Guid(1733211072, 17654, 20231, 185, 121, 76, 114, 63, 192, 133, 151)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVoiceCommandUserMessage
  {
    string DisplayMessage { get; set; }

    string SpokenMessage { get; set; }
  }
}
