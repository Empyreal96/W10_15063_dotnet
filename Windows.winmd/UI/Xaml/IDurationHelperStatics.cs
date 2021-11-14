// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDurationHelperStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (DurationHelper))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3163031870, 13639, 20160, 181, 25, 255, 168, 249, 196, 131, 140)]
  internal interface IDurationHelperStatics
  {
    Duration Automatic { get; }

    Duration Forever { get; }

    int Compare(Duration duration1, Duration duration2);

    Duration FromTimeSpan(TimeSpan timeSpan);

    bool GetHasTimeSpan(Duration target);

    Duration Add(Duration target, Duration duration);

    bool Equals(Duration target, Duration value);

    Duration Subtract(Duration target, Duration duration);
  }
}
