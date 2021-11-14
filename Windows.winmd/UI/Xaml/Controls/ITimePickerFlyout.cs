// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITimePickerFlyout
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TimePickerFlyout))]
  [Guid(3144916341, 59446, 17310, 134, 213, 80, 109, 45, 24, 228, 4)]
  internal interface ITimePickerFlyout
  {
    string ClockIdentifier { get; set; }

    TimeSpan Time { get; set; }

    int MinuteIncrement { get; set; }

    event TypedEventHandler<TimePickerFlyout, TimePickedEventArgs> TimePicked;

    [RemoteAsync]
    IAsyncOperation<IReference<TimeSpan>> ShowAtAsync(
      FrameworkElement target);
  }
}
