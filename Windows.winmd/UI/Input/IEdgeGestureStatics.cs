// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IEdgeGestureStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ExclusiveTo(typeof (EdgeGesture))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3161097497, 6382, 16451, 152, 57, 79, 197, 132, 214, 10, 20)]
  internal interface IEdgeGestureStatics
  {
    EdgeGesture GetForCurrentView();
  }
}
