// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IPointerPoint
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PointerPoint))]
  [Guid(3918868861, 29334, 17113, 130, 51, 197, 190, 115, 183, 74, 74)]
  internal interface IPointerPoint
  {
    PointerDevice PointerDevice { get; }

    Point Position { get; }

    Point RawPosition { get; }

    uint PointerId { get; }

    uint FrameId { get; }

    ulong Timestamp { get; }

    bool IsInContact { get; }

    PointerPointProperties Properties { get; }
  }
}
