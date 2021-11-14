// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITimePicker
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3817904626, 15103, 18322, 144, 158, 45, 153, 65, 236, 3, 87)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TimePicker))]
  internal interface ITimePicker
  {
    object Header { get; set; }

    DataTemplate HeaderTemplate { get; set; }

    string ClockIdentifier { get; set; }

    int MinuteIncrement { get; set; }

    TimeSpan Time { get; set; }

    event EventHandler<TimePickerValueChangedEventArgs> TimeChanged;
  }
}
