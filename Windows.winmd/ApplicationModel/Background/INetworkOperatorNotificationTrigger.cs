// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.INetworkOperatorNotificationTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2416483526, 25549, 18444, 149, 209, 110, 106, 239, 128, 30, 74)]
  [ExclusiveTo(typeof (NetworkOperatorNotificationTrigger))]
  internal interface INetworkOperatorNotificationTrigger : IBackgroundTrigger
  {
    string NetworkAccountId { get; }
  }
}
