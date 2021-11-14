// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.TileFlyoutNotification
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Activatable(typeof (ITileFlyoutNotificationFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  public sealed class TileFlyoutNotification : ITileFlyoutNotification
  {
    [MethodImpl]
    public extern TileFlyoutNotification(XmlDocument content);

    public extern XmlDocument Content { [MethodImpl] get; }

    public extern IReference<DateTime> ExpirationTime { [MethodImpl] set; [MethodImpl] get; }
  }
}
