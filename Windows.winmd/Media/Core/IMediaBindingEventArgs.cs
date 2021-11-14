// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaBindingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (MediaBindingEventArgs))]
  [Guid(3055333978, 7021, 17968, 168, 109, 47, 8, 55, 247, 18, 229)]
  internal interface IMediaBindingEventArgs
  {
    event TypedEventHandler<MediaBindingEventArgs, object> Canceled;

    MediaBinder MediaBinder { get; }

    Deferral GetDeferral();

    void SetUri(Uri uri);

    void SetStream(IRandomAccessStream stream, string contentType);

    void SetStreamReference(IRandomAccessStreamReference stream, string contentType);
  }
}
