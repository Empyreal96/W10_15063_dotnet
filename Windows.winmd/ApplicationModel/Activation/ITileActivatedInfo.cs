// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.ITileActivatedInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Notifications;

namespace Windows.ApplicationModel.Activation
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2162467761, 14720, 20247, 183, 56, 137, 25, 78, 11, 143, 101)]
  [ExclusiveTo(typeof (TileActivatedInfo))]
  internal interface ITileActivatedInfo
  {
    IVectorView<ShownTileNotification> RecentlyShownNotifications { get; }
  }
}
