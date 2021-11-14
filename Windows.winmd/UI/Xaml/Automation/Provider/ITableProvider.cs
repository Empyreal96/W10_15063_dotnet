// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.ITableProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  [WebHostHidden]
  [Guid(2056180633, 26660, 17813, 186, 179, 70, 75, 201, 160, 68, 23)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ITableProvider
  {
    RowOrColumnMajor RowOrColumnMajor { get; }

    IRawElementProviderSimple[] GetColumnHeaders();

    IRawElementProviderSimple[] GetRowHeaders();
  }
}
