// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IItemContainerProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4015839301, 57812, 16628, 186, 213, 199, 250, 212, 74, 112, 62)]
  public interface IItemContainerProvider
  {
    IRawElementProviderSimple FindItemByProperty(
      IRawElementProviderSimple startAfter,
      AutomationProperty automationProperty,
      object value);
  }
}
