// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IInputPaneVisibilityEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ExclusiveTo(typeof (InputPaneVisibilityEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3527663638, 55559, 20428, 187, 141, 247, 123, 170, 80, 40, 241)]
  internal interface IInputPaneVisibilityEventArgs
  {
    Rect OccludedRect { get; }

    bool EnsuredFocusedElementInView { set; get; }
  }
}
