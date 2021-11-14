// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IViewSwitcherProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.ViewManagement;

namespace Windows.ApplicationModel.Activation
{
  [Guid(871532710, 23596, 19751, 186, 199, 117, 54, 8, 143, 18, 25)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IViewSwitcherProvider : IActivatedEventArgs
  {
    ActivationViewSwitcher ViewSwitcher { get; }
  }
}
