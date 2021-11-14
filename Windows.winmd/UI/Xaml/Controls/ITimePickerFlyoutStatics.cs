// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITimePickerFlyoutStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (TimePickerFlyout))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1063725262, 8553, 16387, 180, 168, 141, 231, 3, 90, 10, 214)]
  [WebHostHidden]
  internal interface ITimePickerFlyoutStatics
  {
    DependencyProperty ClockIdentifierProperty { get; }

    DependencyProperty TimeProperty { get; }

    DependencyProperty MinuteIncrementProperty { get; }
  }
}
