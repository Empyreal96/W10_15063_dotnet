// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.MediaTransportControlsThumbnailRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class MediaTransportControlsThumbnailRequestedEventArgs : 
    IMediaTransportControlsThumbnailRequestedEventArgs
  {
    [MethodImpl]
    public extern void SetThumbnailImage(IInputStream source);

    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
