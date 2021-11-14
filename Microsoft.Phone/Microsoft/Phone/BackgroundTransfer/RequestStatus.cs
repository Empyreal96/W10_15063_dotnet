// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.BackgroundTransfer.RequestStatus
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;

namespace Microsoft.Phone.BackgroundTransfer
{
  internal struct RequestStatus
  {
    public TransferStatus TransferStatus;
    public uint TotalBytesToReceive;
    public uint TotalBytesToSend;
    public uint BytesReceived;
    public uint BytesSent;
    public Exception TransferError;
    public uint StatusCode;
    public int HrTransferError;
  }
}
