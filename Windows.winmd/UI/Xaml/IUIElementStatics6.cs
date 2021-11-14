// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IUIElementStatics6
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (UIElement))]
  [Guid(1685980087, 874, 19946, 149, 64, 29, 215, 253, 18, 102, 241)]
  internal interface IUIElementStatics6
  {
    RoutedEvent GettingFocusEvent { get; }

    RoutedEvent LosingFocusEvent { get; }

    RoutedEvent NoFocusCandidateFoundEvent { get; }
  }
}
