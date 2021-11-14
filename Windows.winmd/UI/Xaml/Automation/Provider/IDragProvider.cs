// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IDragProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  [Guid(779585193, 32764, 20311, 185, 101, 30, 241, 243, 115, 245, 70)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IDragProvider
  {
    bool IsGrabbed { get; }

    string DropEffect { get; }

    string[] DropEffects { get; }

    IRawElementProviderSimple[] GetGrabbedItems();
  }
}
