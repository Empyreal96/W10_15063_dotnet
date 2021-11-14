// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IGridProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  [Guid(2338502560, 37676, 17552, 154, 19, 2, 253, 179, 154, 143, 91)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IGridProvider
  {
    int ColumnCount { get; }

    int RowCount { get; }

    IRawElementProviderSimple GetItem(int row, int column);
  }
}
