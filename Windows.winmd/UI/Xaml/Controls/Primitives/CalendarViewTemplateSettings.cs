// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.CalendarViewTemplateSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CalendarViewTemplateSettings : DependencyObject, ICalendarViewTemplateSettings
  {
    public extern double MinViewWidth { [MethodImpl] get; }

    public extern string HeaderText { [MethodImpl] get; }

    public extern string WeekDay1 { [MethodImpl] get; }

    public extern string WeekDay2 { [MethodImpl] get; }

    public extern string WeekDay3 { [MethodImpl] get; }

    public extern string WeekDay4 { [MethodImpl] get; }

    public extern string WeekDay5 { [MethodImpl] get; }

    public extern string WeekDay6 { [MethodImpl] get; }

    public extern string WeekDay7 { [MethodImpl] get; }

    public extern bool HasMoreContentAfter { [MethodImpl] get; }

    public extern bool HasMoreContentBefore { [MethodImpl] get; }

    public extern bool HasMoreViews { [MethodImpl] get; }

    public extern Rect ClipRect { [MethodImpl] get; }

    public extern double CenterX { [MethodImpl] get; }

    public extern double CenterY { [MethodImpl] get; }
  }
}
