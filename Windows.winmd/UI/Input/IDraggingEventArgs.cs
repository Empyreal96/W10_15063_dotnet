// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IDraggingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [Guid(479220612, 2108, 19411, 181, 89, 23, 156, 221, 235, 51, 236)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DraggingEventArgs))]
  internal interface IDraggingEventArgs
  {
    PointerDeviceType PointerDeviceType { get; }

    Point Position { get; }

    DraggingState DraggingState { get; }
  }
}
