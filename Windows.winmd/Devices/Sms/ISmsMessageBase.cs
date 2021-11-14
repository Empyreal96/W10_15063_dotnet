// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.ISmsMessageBase
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(753991216, 65104, 20422, 170, 136, 76, 207, 226, 122, 41, 234)]
  public interface ISmsMessageBase
  {
    SmsMessageType MessageType { get; }

    string DeviceId { get; }

    CellularClass CellularClass { get; }

    SmsMessageClass MessageClass { get; }

    string SimIccId { get; }
  }
}
