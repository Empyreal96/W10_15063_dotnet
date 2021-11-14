// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.MediaMetadata
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Phone.Notification.Management
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  public sealed class MediaMetadata : IMediaMetadata
  {
    public extern string Title { [MethodImpl] get; }

    public extern string Subtitle { [MethodImpl] get; }

    public extern string Artist { [MethodImpl] get; }

    public extern string Album { [MethodImpl] get; }

    public extern uint Track { [MethodImpl] get; }

    public extern TimeSpan Duration { [MethodImpl] get; }

    public extern IRandomAccessStreamReference Thumbnail { [MethodImpl] get; }
  }
}
