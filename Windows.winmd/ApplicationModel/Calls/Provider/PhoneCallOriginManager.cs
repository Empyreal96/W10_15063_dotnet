// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.Provider.PhoneCallOriginManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls.Provider
{
  [ContractVersion(typeof (CallsPhoneContract), 65536)]
  [Static(typeof (IPhoneCallOriginManagerStatics2), 196608, "Windows.ApplicationModel.Calls.CallsPhoneContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IPhoneCallOriginManagerStatics), 65536, "Windows.ApplicationModel.Calls.CallsPhoneContract")]
  public static class PhoneCallOriginManager
  {
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> RequestSetAsActiveCallOriginAppAsync();

    public static extern bool IsCurrentAppActiveCallOriginApp { [MethodImpl] get; }

    [MethodImpl]
    public static extern void ShowPhoneCallOriginSettingsUI();

    [MethodImpl]
    public static extern void SetCallOrigin(Guid requestId, PhoneCallOrigin callOrigin);
  }
}
