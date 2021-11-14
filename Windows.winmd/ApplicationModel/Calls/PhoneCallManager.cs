// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.PhoneCallManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IPhoneCallManagerStatics2), 65536, "Windows.ApplicationModel.Calls.CallsPhoneContract")]
  [Static(typeof (IPhoneCallManagerStatics), 65536, "Windows.ApplicationModel.Calls.CallsPhoneContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (CallsPhoneContract), 65536)]
  public static class PhoneCallManager
  {
    public static extern event EventHandler<object> CallStateChanged;

    public static extern bool IsCallActive { [MethodImpl] get; }

    public static extern bool IsCallIncoming { [MethodImpl] get; }

    [MethodImpl]
    public static extern void ShowPhoneCallSettingsUI();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<PhoneCallStore> RequestStoreAsync();

    [MethodImpl]
    public static extern void ShowPhoneCallUI(string phoneNumber, string displayName);
  }
}
