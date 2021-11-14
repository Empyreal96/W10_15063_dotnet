// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.DurationHelper
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IDurationHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public sealed class DurationHelper : IDurationHelper
  {
    public static extern Duration Automatic { [MethodImpl] get; }

    public static extern Duration Forever { [MethodImpl] get; }

    [MethodImpl]
    public static extern int Compare(Duration duration1, Duration duration2);

    [MethodImpl]
    public static extern Duration FromTimeSpan(TimeSpan timeSpan);

    [MethodImpl]
    public static extern bool GetHasTimeSpan(Duration target);

    [MethodImpl]
    public static extern Duration Add(Duration target, Duration duration);

    [MethodImpl]
    public static extern bool Equals(Duration target, Duration value);

    [MethodImpl]
    public static extern Duration Subtract(Duration target, Duration duration);
  }
}
