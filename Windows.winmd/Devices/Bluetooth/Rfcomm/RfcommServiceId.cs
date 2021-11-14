// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Rfcomm.RfcommServiceId
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Rfcomm
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IRfcommServiceIdStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  public sealed class RfcommServiceId : IRfcommServiceId
  {
    public extern Guid Uuid { [MethodImpl] get; }

    [MethodImpl]
    public extern uint AsShortId();

    [MethodImpl]
    public extern string AsString();

    [MethodImpl]
    public static extern RfcommServiceId FromUuid(Guid uuid);

    [MethodImpl]
    public static extern RfcommServiceId FromShortId(uint shortId);

    public static extern RfcommServiceId SerialPort { [MethodImpl] get; }

    public static extern RfcommServiceId ObexObjectPush { [MethodImpl] get; }

    public static extern RfcommServiceId ObexFileTransfer { [MethodImpl] get; }

    public static extern RfcommServiceId PhoneBookAccessPce { [MethodImpl] get; }

    public static extern RfcommServiceId PhoneBookAccessPse { [MethodImpl] get; }

    public static extern RfcommServiceId GenericFileTransfer { [MethodImpl] get; }
  }
}
