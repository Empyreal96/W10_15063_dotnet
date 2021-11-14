// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ICalendarViewTemplateSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [ExclusiveTo(typeof (CalendarViewTemplateSettings))]
  [Guid(1455887491, 25825, 18300, 138, 11, 203, 47, 51, 52, 185, 176)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICalendarViewTemplateSettings
  {
    double MinViewWidth { get; }

    string HeaderText { get; }

    string WeekDay1 { get; }

    string WeekDay2 { get; }

    string WeekDay3 { get; }

    string WeekDay4 { get; }

    string WeekDay5 { get; }

    string WeekDay6 { get; }

    string WeekDay7 { get; }

    bool HasMoreContentAfter { get; }

    bool HasMoreContentBefore { get; }

    bool HasMoreViews { get; }

    Rect ClipRect { get; }

    double CenterX { get; }

    double CenterY { get; }
  }
}
