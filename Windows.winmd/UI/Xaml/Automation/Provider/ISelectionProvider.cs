// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.ISelectionProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(520196042, 47428, 17301, 141, 225, 136, 246, 116, 175, 81, 211)]
  [WebHostHidden]
  public interface ISelectionProvider
  {
    bool CanSelectMultiple { get; }

    bool IsSelectionRequired { get; }

    IRawElementProviderSimple[] GetSelection();
  }
}
