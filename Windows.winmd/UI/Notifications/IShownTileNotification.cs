// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IShownTileNotification
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (ShownTileNotification))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(875399560, 23282, 18458, 166, 163, 242, 253, 199, 141, 232, 142)]
  internal interface IShownTileNotification
  {
    string Arguments { get; }
  }
}
