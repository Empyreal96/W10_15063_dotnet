// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.MusicProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MusicProperties : IMusicProperties, IStorageItemExtraProperties
  {
    public extern string Album { [MethodImpl] get; [MethodImpl] set; }

    public extern string Artist { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<string> Genre { [MethodImpl] get; }

    public extern uint TrackNumber { [MethodImpl] get; [MethodImpl] set; }

    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    public extern uint Rating { [MethodImpl] get; [MethodImpl] set; }

    public extern TimeSpan Duration { [MethodImpl] get; }

    public extern uint Bitrate { [MethodImpl] get; }

    public extern string AlbumArtist { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<string> Composers { [MethodImpl] get; }

    public extern IVector<string> Conductors { [MethodImpl] get; }

    public extern string Subtitle { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<string> Producers { [MethodImpl] get; }

    public extern string Publisher { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<string> Writers { [MethodImpl] get; }

    public extern uint Year { [MethodImpl] get; [MethodImpl] set; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IMap<string, object>> RetrievePropertiesAsync(
      IIterable<string> propertiesToRetrieve);

    [Overload("SavePropertiesAsync")]
    [MethodImpl]
    public extern IAsyncAction SavePropertiesAsync(
      [HasVariant] IIterable<IKeyValuePair<string, object>> propertiesToSave);

    [Overload("SavePropertiesAsyncOverloadDefault")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SavePropertiesAsync();
  }
}
