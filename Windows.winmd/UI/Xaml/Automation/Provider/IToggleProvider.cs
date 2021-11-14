// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IToggleProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  [WebHostHidden]
  [Guid(2478342800, 25967, 17655, 174, 175, 120, 184, 249, 68, 208, 98)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IToggleProvider
  {
    ToggleState ToggleState { get; }

    void Toggle();
  }
}
