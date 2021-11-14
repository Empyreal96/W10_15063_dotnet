// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Rfcomm.IRfcommServiceIdStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Rfcomm
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RfcommServiceId))]
  [Guid(706191034, 43381, 18147, 181, 107, 8, 255, 215, 131, 165, 254)]
  internal interface IRfcommServiceIdStatics
  {
    RfcommServiceId FromUuid(Guid uuid);

    RfcommServiceId FromShortId(uint shortId);

    RfcommServiceId SerialPort { get; }

    RfcommServiceId ObexObjectPush { get; }

    RfcommServiceId ObexFileTransfer { get; }

    RfcommServiceId PhoneBookAccessPce { get; }

    RfcommServiceId PhoneBookAccessPse { get; }

    RfcommServiceId GenericFileTransfer { get; }
  }
}
