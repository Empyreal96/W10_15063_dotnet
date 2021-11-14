// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICommandBarStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (CommandBar))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3025806500, 35569, 18499, 179, 25, 224, 63, 196, 90, 183, 38)]
  internal interface ICommandBarStatics3
  {
    DependencyProperty DefaultLabelPositionProperty { get; }

    DependencyProperty OverflowButtonVisibilityProperty { get; }

    DependencyProperty IsDynamicOverflowEnabledProperty { get; }
  }
}
