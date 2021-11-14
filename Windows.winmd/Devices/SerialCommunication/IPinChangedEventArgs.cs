// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SerialCommunication.IPinChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SerialCommunication
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2730433968, 64668, 17927, 147, 208, 250, 94, 131, 67, 238, 34)]
  [ExclusiveTo(typeof (PinChangedEventArgs))]
  internal interface IPinChangedEventArgs
  {
    SerialPinChange PinChange { get; }
  }
}
