// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IHoldingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ExclusiveTo(typeof (HoldingEventArgs))]
  [Guid(737629637, 59289, 16820, 187, 64, 36, 47, 64, 149, 155, 113)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHoldingEventArgs
  {
    PointerDeviceType PointerDeviceType { get; }

    Point Position { get; }

    HoldingState HoldingState { get; }
  }
}
