// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IFindNextElementOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ExclusiveTo(typeof (FindNextElementOptions))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  [Guid(3632980523, 18114, 16892, 137, 126, 181, 150, 25, 119, 184, 157)]
  internal interface IFindNextElementOptions
  {
    DependencyObject SearchRoot { get; set; }

    Rect ExclusionRect { get; set; }

    Rect HintRect { get; set; }

    XYFocusNavigationStrategyOverride XYFocusNavigationStrategyOverride { get; set; }
  }
}
