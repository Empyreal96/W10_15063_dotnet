// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IChatMessageReceivedNotificationTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ChatMessageReceivedNotificationTrigger))]
  [Guid(1050899982, 47861, 16503, 136, 233, 6, 12, 246, 240, 198, 213)]
  internal interface IChatMessageReceivedNotificationTrigger : IBackgroundTrigger
  {
  }
}
