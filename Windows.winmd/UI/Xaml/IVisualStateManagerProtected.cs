// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IVisualStateManagerProtected
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1262192192, 45239, 16460, 158, 244, 217, 73, 100, 14, 36, 93)]
  [ExclusiveTo(typeof (VisualStateManager))]
  [WebHostHidden]
  internal interface IVisualStateManagerProtected
  {
    void RaiseCurrentStateChanging(
      VisualStateGroup stateGroup,
      VisualState oldState,
      VisualState newState,
      Control control);

    void RaiseCurrentStateChanged(
      VisualStateGroup stateGroup,
      VisualState oldState,
      VisualState newState,
      Control control);
  }
}
