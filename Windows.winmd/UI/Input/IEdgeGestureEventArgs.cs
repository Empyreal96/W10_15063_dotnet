// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IEdgeGestureEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ExclusiveTo(typeof (EdgeGestureEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1157253668, 11529, 17121, 139, 94, 54, 130, 8, 121, 106, 76)]
  internal interface IEdgeGestureEventArgs
  {
    EdgeGestureKind Kind { get; }
  }
}
