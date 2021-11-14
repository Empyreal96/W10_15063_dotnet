// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IUIElementStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ExclusiveTo(typeof (UIElement))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3522722526, 60577, 17761, 163, 43, 100, 96, 27, 78, 5, 151)]
  internal interface IUIElementStatics3
  {
    DependencyProperty Transform3DProperty { [IndependentlyAnimatable] get; }

    DependencyProperty CanDragProperty { get; }

    bool TryStartDirectManipulation(Pointer value);
  }
}
