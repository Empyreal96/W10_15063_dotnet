// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.ISmsFilterRule
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SmsFilterRule))]
  [Guid(1088630702, 45129, 20412, 175, 233, 226, 166, 16, 239, 245, 92)]
  internal interface ISmsFilterRule
  {
    SmsMessageType MessageType { get; }

    IVector<string> ImsiPrefixes { get; }

    IVector<string> DeviceIds { get; }

    IVector<string> SenderNumbers { get; }

    IVector<string> TextMessagePrefixes { get; }

    IVector<int> PortNumbers { get; }

    CellularClass CellularClass { get; set; }

    IVector<int> ProtocolIds { get; }

    IVector<int> TeleserviceIds { get; }

    IVector<string> WapApplicationIds { get; }

    IVector<string> WapContentTypes { get; }

    IVector<SmsBroadcastType> BroadcastTypes { get; }

    IVector<int> BroadcastChannels { get; }
  }
}
