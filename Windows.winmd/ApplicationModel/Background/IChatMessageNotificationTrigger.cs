// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IChatMessageNotificationTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(1362838463, 7488, 23645, 120, 245, 201, 35, 254, 227, 115, 158)]
  [ExclusiveTo(typeof (ChatMessageNotificationTrigger))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IChatMessageNotificationTrigger : IBackgroundTrigger
  {
  }
}
