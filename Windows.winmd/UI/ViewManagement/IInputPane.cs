// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IInputPane
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [Guid(1678432880, 1779, 19591, 166, 120, 152, 41, 201, 18, 124, 40)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (InputPane))]
  internal interface IInputPane
  {
    event TypedEventHandler<InputPane, InputPaneVisibilityEventArgs> Showing;

    event TypedEventHandler<InputPane, InputPaneVisibilityEventArgs> Hiding;

    Rect OccludedRect { get; }
  }
}
