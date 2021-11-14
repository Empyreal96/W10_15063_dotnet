// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IDockProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  [WebHostHidden]
  [Guid(1220690936, 30897, 17568, 172, 95, 117, 7, 87, 188, 222, 60)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IDockProvider
  {
    DockPosition DockPosition { get; }

    void SetDockPosition(DockPosition dockPosition);
  }
}
