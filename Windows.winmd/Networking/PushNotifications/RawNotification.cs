// Decompiled with JetBrains decompiler
// Type: Windows.Networking.PushNotifications.RawNotification
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.PushNotifications
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class RawNotification : IRawNotification, IRawNotification2
  {
    public extern string Content { [MethodImpl] get; }

    public extern IMapView<string, string> Headers { [MethodImpl] get; }

    public extern string ChannelId { [MethodImpl] get; }
  }
}
