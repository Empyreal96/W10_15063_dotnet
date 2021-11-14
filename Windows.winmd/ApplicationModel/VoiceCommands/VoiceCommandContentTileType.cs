// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.VoiceCommandContentTileType
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.VoiceCommands
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum VoiceCommandContentTileType
  {
    TitleOnly,
    TitleWithText,
    TitleWith68x68Icon,
    TitleWith68x68IconAndText,
    TitleWith68x92Icon,
    TitleWith68x92IconAndText,
    TitleWith280x140Icon,
    TitleWith280x140IconAndText,
  }
}
