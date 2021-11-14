// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.IServiceRequestedEventArgs2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Playback;

namespace Windows.Media.Protection
{
  [Guid(1430022614, 64254, 16680, 141, 250, 19, 14, 57, 138, 19, 167)]
  [ExclusiveTo(typeof (ServiceRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IServiceRequestedEventArgs2
  {
    MediaPlaybackItem MediaPlaybackItem { get; }
  }
}
