// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.ICustomNavigationProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Windows.UI.Xaml.Automation.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(735618768, 12195, 18199, 178, 140, 73, 23, 206, 84, 146, 141)]
  public interface ICustomNavigationProvider
  {
    object NavigateCustom(AutomationNavigationDirection direction);
  }
}
