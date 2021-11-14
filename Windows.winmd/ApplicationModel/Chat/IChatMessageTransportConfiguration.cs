// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageTransportConfiguration
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.ApplicationModel.Chat
{
  [ExclusiveTo(typeof (ChatMessageTransportConfiguration))]
  [Guid(2275407653, 6664, 19146, 160, 117, 51, 85, 18, 99, 18, 230)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IChatMessageTransportConfiguration
  {
    int MaxAttachmentCount { get; }

    int MaxMessageSizeInKilobytes { get; }

    int MaxRecipientCount { get; }

    MediaEncodingProfile SupportedVideoFormat { get; }

    IMapView<string, object> ExtendedProperties { get; }
  }
}
