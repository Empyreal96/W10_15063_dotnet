// Decompiled with JetBrains decompiler
// Type: Windows.Networking.PushNotifications.IRawNotification2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.PushNotifications
{
  [Guid(3872444185, 3183, 19677, 148, 36, 238, 197, 190, 1, 77, 38)]
  [ExclusiveTo(typeof (RawNotification))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IRawNotification2
  {
    IMapView<string, string> Headers { get; }

    string ChannelId { get; }
  }
}
