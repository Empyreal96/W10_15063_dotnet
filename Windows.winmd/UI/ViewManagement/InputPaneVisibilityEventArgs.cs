// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.InputPaneVisibilityEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class InputPaneVisibilityEventArgs : IInputPaneVisibilityEventArgs
  {
    public extern Rect OccludedRect { [MethodImpl] get; }

    public extern bool EnsuredFocusedElementInView { [MethodImpl] set; [MethodImpl] get; }
  }
}
