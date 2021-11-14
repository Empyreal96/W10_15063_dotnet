// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.IMediaClipStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.UI;

namespace Windows.Media.Editing
{
  [ExclusiveTo(typeof (MediaClip))]
  [Guid(4198509416, 37519, 17348, 188, 110, 120, 58, 26, 53, 150, 86)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaClipStatics
  {
    MediaClip CreateFromColor(Color color, TimeSpan originalDuration);

    [RemoteAsync]
    IAsyncOperation<MediaClip> CreateFromFileAsync(IStorageFile file);

    [RemoteAsync]
    IAsyncOperation<MediaClip> CreateFromImageFileAsync(
      IStorageFile file,
      TimeSpan originalDuration);
  }
}
