// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.PhoneCallBlocking
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [ContractVersion(typeof (CallsPhoneContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IPhoneCallBlockingStatics), 65536, "Windows.ApplicationModel.Calls.CallsPhoneContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class PhoneCallBlocking
  {
    public static extern bool BlockUnknownNumbers { [MethodImpl] get; [MethodImpl] set; }

    public static extern bool BlockPrivateNumbers { [MethodImpl] get; [MethodImpl] set; }

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> SetCallBlockingListAsync(
      IIterable<string> phoneNumberList);
  }
}
