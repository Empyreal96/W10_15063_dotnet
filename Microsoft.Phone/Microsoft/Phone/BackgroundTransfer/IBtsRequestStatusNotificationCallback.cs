// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.BackgroundTransfer.IBtsRequestStatusNotificationCallback
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.InteropServices;

namespace Microsoft.Phone.BackgroundTransfer
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("B28979AA-2215-416f-9AA8-13CB959AFE7B")]
  [ComImport]
  internal interface IBtsRequestStatusNotificationCallback
  {
    void OnNotify(int hrStatus, [In] IntPtr notifyData);
  }
}
