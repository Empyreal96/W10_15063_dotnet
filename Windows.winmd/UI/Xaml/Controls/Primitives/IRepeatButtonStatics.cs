// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IRepeatButtonStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ExclusiveTo(typeof (RepeatButton))]
  [WebHostHidden]
  [Guid(957656142, 62562, 20339, 129, 151, 232, 132, 102, 57, 198, 130)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRepeatButtonStatics
  {
    DependencyProperty DelayProperty { get; }

    DependencyProperty IntervalProperty { get; }
  }
}
