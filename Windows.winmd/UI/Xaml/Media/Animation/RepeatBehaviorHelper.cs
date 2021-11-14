// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.RepeatBehaviorHelper
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Static(typeof (IRepeatBehaviorHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RepeatBehaviorHelper : IRepeatBehaviorHelper
  {
    public static extern RepeatBehavior Forever { [MethodImpl] get; }

    [MethodImpl]
    public static extern RepeatBehavior FromCount(double count);

    [MethodImpl]
    public static extern RepeatBehavior FromDuration(TimeSpan duration);

    [MethodImpl]
    public static extern bool GetHasCount(RepeatBehavior target);

    [MethodImpl]
    public static extern bool GetHasDuration(RepeatBehavior target);

    [MethodImpl]
    public static extern bool Equals(RepeatBehavior target, RepeatBehavior value);
  }
}
