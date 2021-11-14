// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.IVoiceCommandDisambiguationResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.VoiceCommands
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3972435198, 51628, 17887, 168, 234, 254, 234, 8, 239, 156, 94)]
  [ExclusiveTo(typeof (VoiceCommandDisambiguationResult))]
  internal interface IVoiceCommandDisambiguationResult
  {
    VoiceCommandContentTile SelectedItem { get; }
  }
}
