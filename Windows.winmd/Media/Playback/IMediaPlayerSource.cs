// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlayerSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Core;
using Windows.Media.Protection;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Media.Playback
{
  [Guid(3176106135, 5155, 19518, 130, 197, 15, 177, 175, 148, 247, 21)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaPlayer))]
  internal interface IMediaPlayerSource
  {
    MediaProtectionManager ProtectionManager { get; set; }

    [Deprecated("Use Source instead of SetFileSource.  For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.Foundation.UniversalApiContract")]
    void SetFileSource(IStorageFile file);

    [Deprecated("Use Source instead of SetStreamSource.  For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.Foundation.UniversalApiContract")]
    void SetStreamSource(IRandomAccessStream stream);

    [Deprecated("Use Source instead of SetMediaSource.  For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.Foundation.UniversalApiContract")]
    void SetMediaSource(IMediaSource source);
  }
}
