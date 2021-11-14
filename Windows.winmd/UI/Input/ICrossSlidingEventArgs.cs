// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.ICrossSlidingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [Guid(3912714040, 28552, 16857, 135, 32, 120, 224, 142, 57, 131, 73)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CrossSlidingEventArgs))]
  internal interface ICrossSlidingEventArgs
  {
    PointerDeviceType PointerDeviceType { get; }

    Point Position { get; }

    CrossSlidingState CrossSlidingState { get; }
  }
}
