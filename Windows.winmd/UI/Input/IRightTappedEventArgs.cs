// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IRightTappedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [Guid(1287602365, 44922, 18998, 148, 118, 177, 220, 225, 65, 112, 154)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RightTappedEventArgs))]
  internal interface IRightTappedEventArgs
  {
    PointerDeviceType PointerDeviceType { get; }

    Point Position { get; }
  }
}
