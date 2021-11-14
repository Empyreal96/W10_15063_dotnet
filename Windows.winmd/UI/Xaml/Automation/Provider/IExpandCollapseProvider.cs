// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IExpandCollapseProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1236042649, 54822, 17731, 148, 185, 166, 217, 169, 89, 58, 246)]
  public interface IExpandCollapseProvider
  {
    ExpandCollapseState ExpandCollapseState { get; }

    void Collapse();

    void Expand();
  }
}
