// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Rfcomm.IRfcommServiceId
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Rfcomm
{
  [Guid(576885252, 32258, 16407, 129, 54, 218, 27, 106, 27, 155, 191)]
  [ExclusiveTo(typeof (RfcommServiceId))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRfcommServiceId
  {
    Guid Uuid { get; }

    uint AsShortId();

    string AsString();
  }
}
