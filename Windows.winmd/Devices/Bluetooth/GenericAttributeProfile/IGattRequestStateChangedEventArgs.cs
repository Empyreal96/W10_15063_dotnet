// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattRequestStateChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattRequestStateChangedEventArgs))]
  [Guid(3895777580, 10174, 17587, 157, 13, 79, 198, 232, 8, 221, 63)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IGattRequestStateChangedEventArgs
  {
    GattRequestState State { get; }

    BluetoothError Error { get; }
  }
}
