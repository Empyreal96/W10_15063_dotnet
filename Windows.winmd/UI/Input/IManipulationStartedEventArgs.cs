// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IManipulationStartedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ExclusiveTo(typeof (ManipulationStartedEventArgs))]
  [Guid(3723265854, 53198, 18738, 140, 29, 60, 61, 1, 26, 52, 192)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IManipulationStartedEventArgs
  {
    PointerDeviceType PointerDeviceType { get; }

    Point Position { get; }

    ManipulationDelta Cumulative { get; }
  }
}
