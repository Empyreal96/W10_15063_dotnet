// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.VoiceCommandContentTile
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.VoiceCommands
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class VoiceCommandContentTile : IVoiceCommandContentTile
  {
    [MethodImpl]
    public extern VoiceCommandContentTile();

    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    public extern string TextLine1 { [MethodImpl] get; [MethodImpl] set; }

    public extern string TextLine2 { [MethodImpl] get; [MethodImpl] set; }

    public extern string TextLine3 { [MethodImpl] get; [MethodImpl] set; }

    public extern IStorageFile Image { [MethodImpl] get; [MethodImpl] set; }

    public extern object AppContext { [MethodImpl] get; [MethodImpl] set; }

    public extern string AppLaunchArgument { [MethodImpl] get; [MethodImpl] set; }

    public extern VoiceCommandContentTileType ContentTileType { [MethodImpl] get; [MethodImpl] set; }
  }
}
