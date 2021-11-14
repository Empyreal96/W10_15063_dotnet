// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IMultipleViewProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3491029398, 3664, 18499, 165, 210, 194, 40, 151, 200, 132, 90)]
  public interface IMultipleViewProvider
  {
    int CurrentView { get; }

    int[] GetSupportedViews();

    string GetViewName(int viewId);

    void SetCurrentView(int viewId);
  }
}
