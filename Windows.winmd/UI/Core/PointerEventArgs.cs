// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.PointerEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.UI.Input;

namespace Windows.UI.Core
{
  [MarshalingBehavior(MarshalingType.Standard)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PointerEventArgs : IPointerEventArgs, ICoreWindowEventArgs
  {
    public extern PointerPoint CurrentPoint { [MethodImpl] get; }

    public extern VirtualKeyModifiers KeyModifiers { [MethodImpl] get; }

    [MethodImpl]
    public extern IVector<PointerPoint> GetIntermediatePoints();

    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }
  }
}
