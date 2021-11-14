// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.ITappedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TappedEventArgs))]
  [Guid(3483444964, 9530, 19516, 149, 59, 57, 92, 55, 174, 211, 9)]
  internal interface ITappedEventArgs
  {
    PointerDeviceType PointerDeviceType { get; }

    Point Position { get; }

    uint TapCount { get; }
  }
}
