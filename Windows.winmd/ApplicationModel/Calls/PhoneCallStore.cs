// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.PhoneCallStore
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (CallsPhoneContract), 65536)]
  public sealed class PhoneCallStore : IPhoneCallStore
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> IsEmergencyPhoneNumberAsync(string number);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<Guid> GetDefaultLineAsync();

    [MethodImpl]
    public extern PhoneLineWatcher RequestLineWatcher();
  }
}
