// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.ISpreadsheetProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(355831955, 48537, 19709, 159, 7, 59, 20, 179, 21, 226, 61)]
  public interface ISpreadsheetProvider
  {
    IRawElementProviderSimple GetItemByName(string name);
  }
}
