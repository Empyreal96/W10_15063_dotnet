// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.IMediaOverlay
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Editing
{
  [Guid(2835525213, 30825, 18480, 138, 177, 148, 220, 1, 192, 95, 164)]
  [ExclusiveTo(typeof (MediaOverlay))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaOverlay
  {
    Rect Position { get; set; }

    TimeSpan Delay { set; get; }

    double Opacity { get; set; }

    MediaOverlay Clone();

    MediaClip Clip { get; }

    bool AudioEnabled { get; set; }
  }
}
