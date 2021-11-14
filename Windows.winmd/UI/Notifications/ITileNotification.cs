// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ITileNotification
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (TileNotification))]
  [Guid(3954100474, 20716, 19480, 180, 208, 58, 240, 46, 85, 64, 171)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITileNotification
  {
    XmlDocument Content { get; }

    IReference<DateTime> ExpirationTime { set; get; }

    string Tag { set; get; }
  }
}
