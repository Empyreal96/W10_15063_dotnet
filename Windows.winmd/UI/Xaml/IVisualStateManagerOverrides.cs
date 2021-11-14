// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IVisualStateManagerOverrides
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml
{
  [Guid(1248235790, 31097, 17352, 143, 244, 236, 97, 34, 117, 0, 6)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (VisualStateManager))]
  internal interface IVisualStateManagerOverrides
  {
    bool GoToStateCore(
      Control control,
      FrameworkElement templateRoot,
      string stateName,
      VisualStateGroup group,
      VisualState state,
      bool useTransitions);
  }
}
