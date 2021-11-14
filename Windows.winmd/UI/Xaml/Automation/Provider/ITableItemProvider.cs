// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.ITableItemProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(992758221, 7650, 20194, 163, 225, 251, 85, 53, 89, 209, 93)]
  public interface ITableItemProvider
  {
    IRawElementProviderSimple[] GetColumnHeaderItems();

    IRawElementProviderSimple[] GetRowHeaderItems();
  }
}
