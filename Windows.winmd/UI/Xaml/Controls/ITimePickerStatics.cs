// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITimePickerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4201766833, 9022, 20273, 184, 190, 166, 234, 103, 12, 37, 205)]
  [WebHostHidden]
  [ExclusiveTo(typeof (TimePicker))]
  internal interface ITimePickerStatics
  {
    DependencyProperty HeaderProperty { get; }

    DependencyProperty HeaderTemplateProperty { get; }

    DependencyProperty ClockIdentifierProperty { get; }

    DependencyProperty MinuteIncrementProperty { get; }

    DependencyProperty TimeProperty { get; }
  }
}
