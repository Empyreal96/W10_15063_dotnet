// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.BackgroundTransfer.BtsTransferParams
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.InteropServices;

namespace Microsoft.Phone.BackgroundTransfer
{
  internal struct BtsTransferParams
  {
    [MarshalAs(UnmanagedType.LPWStr)]
    public string Uri;
    [MarshalAs(UnmanagedType.I4)]
    public BtsHttpVerb Verb;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string CustomData;
    [MarshalAs(UnmanagedType.U4)]
    public uint NumCustomAddRequestHeaders;
    public IntPtr CustomAddRequestHeaders;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string FileName;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string UploadFileName;
    [MarshalAs(UnmanagedType.U4)]
    public BtsTransferFlags TransferFlags;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string FileToken;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string UploadFileToken;
    [MarshalAs(UnmanagedType.U4)]
    public uint RequestStateWnfStateNameSize;
    public IntPtr RequestStateWnfStateName;
    [MarshalAs(UnmanagedType.U4)]
    public uint ConnectionDataPlanUsageState;
    [MarshalAs(UnmanagedType.U4)]
    public uint DataAttributionType;
    public IntPtr TransferOriginatorProductId;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string CertificateSearchCriteria;
  }
}
