// Decompiled with JetBrains decompiler
// Type: Windows.Media.IAutoRepeatModeChangeRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [Guid(3927146234, 55378, 17294, 136, 43, 201, 144, 16, 154, 120, 244)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AutoRepeatModeChangeRequestedEventArgs))]
  internal interface IAutoRepeatModeChangeRequestedEventArgs
  {
    MediaPlaybackAutoRepeatMode RequestedAutoRepeatMode { get; }
  }
}
