// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IRepeatBehaviorHelperStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Guid(2054770739, 31219, 19929, 178, 103, 156, 245, 15, 181, 31, 132)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RepeatBehaviorHelper))]
  internal interface IRepeatBehaviorHelperStatics
  {
    RepeatBehavior Forever { get; }

    RepeatBehavior FromCount(double count);

    RepeatBehavior FromDuration(TimeSpan duration);

    bool GetHasCount(RepeatBehavior target);

    bool GetHasDuration(RepeatBehavior target);

    bool Equals(RepeatBehavior target, RepeatBehavior value);
  }
}
