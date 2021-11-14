// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IVisualStateManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ExclusiveTo(typeof (VisualStateManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(30468576, 55059, 16718, 167, 78, 230, 62, 199, 172, 140, 61)]
  internal interface IVisualStateManagerStatics
  {
    IVector<VisualStateGroup> GetVisualStateGroups(FrameworkElement obj);

    DependencyProperty CustomVisualStateManagerProperty { get; }

    VisualStateManager GetCustomVisualStateManager(FrameworkElement obj);

    void SetCustomVisualStateManager(FrameworkElement obj, VisualStateManager value);

    bool GoToState(Control control, string stateName, bool useTransitions);
  }
}
