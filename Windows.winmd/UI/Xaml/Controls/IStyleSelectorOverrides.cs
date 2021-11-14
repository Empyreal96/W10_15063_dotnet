// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IStyleSelectorOverrides
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(145610349, 3630, 17312, 174, 202, 143, 170, 148, 185, 208, 23)]
  [ExclusiveTo(typeof (StyleSelector))]
  internal interface IStyleSelectorOverrides
  {
    Style SelectStyleCore(object item, DependencyObject container);
  }
}
