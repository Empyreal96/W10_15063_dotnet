// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.IPointerEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.UI.Input;

namespace Windows.UI.Core
{
  [WebHostHidden]
  [ExclusiveTo(typeof (PointerEventArgs))]
  [Guid(2450365617, 42492, 18977, 140, 9, 73, 223, 230, 255, 226, 95)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPointerEventArgs : ICoreWindowEventArgs
  {
    PointerPoint CurrentPoint { get; }

    VirtualKeyModifiers KeyModifiers { get; }

    IVector<PointerPoint> GetIntermediatePoints();
  }
}
