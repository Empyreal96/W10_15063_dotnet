// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IRcsTransportConfiguration
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [Guid(533508354, 9330, 19385, 153, 136, 193, 33, 28, 131, 232, 169)]
  [ExclusiveTo(typeof (RcsTransportConfiguration))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRcsTransportConfiguration
  {
    int MaxAttachmentCount { get; }

    int MaxMessageSizeInKilobytes { get; }

    int MaxGroupMessageSizeInKilobytes { get; }

    int MaxRecipientCount { get; }

    int MaxFileSizeInKilobytes { get; }

    int WarningFileSizeInKilobytes { get; }
  }
}
