// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IEdgeGesture
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EdgeGesture))]
  [Guid(1477268114, 10929, 18858, 167, 240, 51, 189, 63, 141, 249, 241)]
  internal interface IEdgeGesture
  {
    event TypedEventHandler<EdgeGesture, EdgeGestureEventArgs> Starting;

    event TypedEventHandler<EdgeGesture, EdgeGestureEventArgs> Completed;

    event TypedEventHandler<EdgeGesture, EdgeGestureEventArgs> Canceled;
  }
}
