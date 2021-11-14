// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.ISelectionItemProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  [Guid(1783199681, 33549, 17106, 191, 98, 4, 46, 189, 222, 204, 25)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ISelectionItemProvider
  {
    bool IsSelected { get; }

    IRawElementProviderSimple SelectionContainer { get; }

    void AddToSelection();

    void RemoveFromSelection();

    void Select();
  }
}
