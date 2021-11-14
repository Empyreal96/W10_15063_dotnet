// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IGridItemProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  [Guid(4294142012, 29703, 17851, 169, 54, 223, 62, 214, 211, 131, 125)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public interface IGridItemProvider
  {
    int Column { get; }

    int ColumnSpan { get; }

    IRawElementProviderSimple ContainingGrid { get; }

    int Row { get; }

    int RowSpan { get; }
  }
}
