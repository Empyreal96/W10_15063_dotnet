// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatMessageStatus
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ChatMessageStatus
  {
    Draft,
    Sending,
    Sent,
    SendRetryNeeded,
    SendFailed,
    Received,
    ReceiveDownloadNeeded,
    ReceiveDownloadFailed,
    ReceiveDownloading,
    Deleted,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Declined,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Cancelled,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Recalled,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] ReceiveRetryNeeded,
  }
}
