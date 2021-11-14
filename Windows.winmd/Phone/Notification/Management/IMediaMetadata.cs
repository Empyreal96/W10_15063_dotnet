// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.IMediaMetadata
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Phone.Notification.Management
{
  [Guid(2605768183, 47980, 17200, 179, 205, 7, 4, 165, 76, 219, 128)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [ExclusiveTo(typeof (MediaMetadata))]
  internal interface IMediaMetadata
  {
    string Title { get; }

    string Subtitle { get; }

    string Artist { get; }

    string Album { get; }

    uint Track { get; }

    TimeSpan Duration { get; }

    IRandomAccessStreamReference Thumbnail { get; }
  }
}
