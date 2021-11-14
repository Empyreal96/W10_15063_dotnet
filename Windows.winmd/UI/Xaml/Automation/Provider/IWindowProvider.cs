// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IWindowProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  [Guid(464161597, 14543, 16730, 133, 211, 32, 228, 58, 14, 193, 177)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IWindowProvider
  {
    bool IsModal { get; }

    bool IsTopmost { get; }

    bool Maximizable { get; }

    bool Minimizable { get; }

    WindowInteractionState InteractionState { get; }

    WindowVisualState VisualState { get; }

    void Close();

    void SetVisualState(WindowVisualState state);

    bool WaitForInputIdle(int milliseconds);
  }
}
