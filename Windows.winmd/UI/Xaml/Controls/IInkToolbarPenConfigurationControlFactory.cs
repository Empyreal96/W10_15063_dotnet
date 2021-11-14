// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarPenConfigurationControlFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (InkToolbarPenConfigurationControl))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1743807982, 62951, 18155, 145, 135, 141, 60, 163, 175, 137, 27)]
  internal interface IInkToolbarPenConfigurationControlFactory
  {
    InkToolbarPenConfigurationControl CreateInstance(
      object outer,
      out object inner);
  }
}
