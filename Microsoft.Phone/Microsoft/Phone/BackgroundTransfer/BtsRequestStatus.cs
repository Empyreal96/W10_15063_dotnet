// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.BackgroundTransfer.BtsRequestStatus
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Runtime.InteropServices;

namespace Microsoft.Phone.BackgroundTransfer
{
  internal struct BtsRequestStatus
  {
    [MarshalAs(UnmanagedType.I4)]
    public BtsRequestState RequestState;
    [MarshalAs(UnmanagedType.U4)]
    public uint TotalBytes;
    [MarshalAs(UnmanagedType.U4)]
    public uint TotalUploadBytes;
    [MarshalAs(UnmanagedType.U4)]
    public uint CurrentBytes;
    [MarshalAs(UnmanagedType.Bool)]
    public bool Uploading;
    [MarshalAs(UnmanagedType.I4)]
    public int HrStatus;
    [MarshalAs(UnmanagedType.U4)]
    public uint HttpStatus;
  }
}
