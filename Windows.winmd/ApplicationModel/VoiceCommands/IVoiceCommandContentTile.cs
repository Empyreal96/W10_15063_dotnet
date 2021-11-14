// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.IVoiceCommandContentTile
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.VoiceCommands
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VoiceCommandContentTile))]
  [Guid(1055910384, 47303, 19574, 160, 222, 22, 7, 137, 94, 227, 39)]
  internal interface IVoiceCommandContentTile
  {
    string Title { get; set; }

    string TextLine1 { get; set; }

    string TextLine2 { get; set; }

    string TextLine3 { get; set; }

    IStorageFile Image { get; set; }

    object AppContext { get; set; }

    string AppLaunchArgument { get; set; }

    VoiceCommandContentTileType ContentTileType { get; set; }
  }
}
