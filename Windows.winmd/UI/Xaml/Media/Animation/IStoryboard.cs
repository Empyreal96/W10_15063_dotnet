// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IStoryboard
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Guid(3562806894, 13716, 17934, 152, 26, 50, 39, 27, 211, 170, 6)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Storyboard))]
  internal interface IStoryboard
  {
    TimelineCollection Children { get; }

    void Seek(TimeSpan offset);

    void Stop();

    void Begin();

    void Pause();

    void Resume();

    ClockState GetCurrentState();

    TimeSpan GetCurrentTime();

    void SeekAlignedToLastTick(TimeSpan offset);

    void SkipToFill();
  }
}
