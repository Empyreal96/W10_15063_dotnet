// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.CommunicationBlocking.ICommunicationBlockingAccessManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.CommunicationBlocking
{
  [ExclusiveTo(typeof (CommunicationBlockingAccessManager))]
  [Guid(479631768, 40234, 23991, 237, 213, 12, 228, 7, 252, 37, 149)]
  [ContractVersion(typeof (CommunicationBlockingContract), 65536)]
  internal interface ICommunicationBlockingAccessManagerStatics
  {
    bool IsBlockingActive { get; }

    [RemoteAsync]
    IAsyncOperation<bool> IsBlockedNumberAsync(string number);

    bool ShowBlockNumbersUI(IIterable<string> phoneNumbers);

    bool ShowUnblockNumbersUI(IIterable<string> phoneNumbers);

    void ShowBlockedCallsUI();

    void ShowBlockedMessagesUI();
  }
}
