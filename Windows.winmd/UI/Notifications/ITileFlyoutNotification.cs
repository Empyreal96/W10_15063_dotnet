// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ITileFlyoutNotification
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (TileFlyoutNotification))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2589176417, 50956, 17086, 178, 243, 244, 42, 169, 125, 52, 229)]
  internal interface ITileFlyoutNotification
  {
    XmlDocument Content { get; }

    IReference<DateTime> ExpirationTime { set; get; }
  }
}
