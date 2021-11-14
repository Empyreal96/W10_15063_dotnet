// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IMediaTransportControlsThumbnailRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (MediaTransportControlsThumbnailRequestedEventArgs))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3836260892, 58306, 18524, 174, 105, 241, 83, 123, 118, 117, 90)]
  internal interface IMediaTransportControlsThumbnailRequestedEventArgs
  {
    void SetThumbnailImage(IInputStream source);

    Deferral GetDeferral();
  }
}
