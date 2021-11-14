// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.CommunicationBlocking.CommunicationBlockingAccessManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.CommunicationBlocking
{
  [ContractVersion(typeof (CommunicationBlockingContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ICommunicationBlockingAccessManagerStatics), 65536, "Windows.ApplicationModel.CommunicationBlocking.CommunicationBlockingContract")]
  public static class CommunicationBlockingAccessManager
  {
    public static extern bool IsBlockingActive { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> IsBlockedNumberAsync(string number);

    [MethodImpl]
    public static extern bool ShowBlockNumbersUI(IIterable<string> phoneNumbers);

    [MethodImpl]
    public static extern bool ShowUnblockNumbersUI(IIterable<string> phoneNumbers);

    [MethodImpl]
    public static extern void ShowBlockedCallsUI();

    [MethodImpl]
    public static extern void ShowBlockedMessagesUI();
  }
}
