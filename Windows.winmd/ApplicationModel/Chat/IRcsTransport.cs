// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IRcsTransport
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [Guid(4272113497, 62332, 17177, 133, 70, 236, 132, 210, 29, 48, 255)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RcsTransport))]
  internal interface IRcsTransport
  {
    IMapView<string, object> ExtendedProperties { get; }

    bool IsActive { get; }

    string TransportFriendlyName { get; }

    string TransportId { get; }

    RcsTransportConfiguration Configuration { get; }

    bool IsStoreAndForwardEnabled(RcsServiceKind serviceKind);

    bool IsServiceKindSupported(RcsServiceKind serviceKind);

    event TypedEventHandler<RcsTransport, RcsServiceKindSupportedChangedEventArgs> ServiceKindSupportedChanged;
  }
}
