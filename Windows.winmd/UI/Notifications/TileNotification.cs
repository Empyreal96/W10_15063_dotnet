// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.TileNotification
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Activatable(typeof (ITileNotificationFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class TileNotification : ITileNotification
  {
    [MethodImpl]
    public extern TileNotification(XmlDocument content);

    public extern XmlDocument Content { [MethodImpl] get; }

    public extern IReference<DateTime> ExpirationTime { [MethodImpl] set; [MethodImpl] get; }

    public extern string Tag { [MethodImpl] set; [MethodImpl] get; }
  }
}
