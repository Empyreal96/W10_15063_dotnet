// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageTransport
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1672076280, 59059, 23706, 95, 133, 212, 121, 37, 185, 189, 24)]
  [ExclusiveTo(typeof (ChatMessageTransport))]
  internal interface IChatMessageTransport
  {
    bool IsAppSetAsNotificationProvider { get; }

    bool IsActive { get; }

    string TransportFriendlyName { get; }

    string TransportId { get; }

    [RemoteAsync]
    IAsyncAction RequestSetAsNotificationProviderAsync();
  }
}
