// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaBinder
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(729694378, 56839, 16975, 131, 241, 241, 222, 70, 196, 250, 46)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (MediaBinder))]
  internal interface IMediaBinder
  {
    event TypedEventHandler<MediaBinder, MediaBindingEventArgs> Binding;

    string Token { get; set; }

    MediaSource Source { get; }
  }
}
