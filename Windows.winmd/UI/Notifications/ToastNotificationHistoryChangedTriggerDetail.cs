// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ToastNotificationHistoryChangedTriggerDetail
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class ToastNotificationHistoryChangedTriggerDetail : 
    IToastNotificationHistoryChangedTriggerDetail,
    IToastNotificationHistoryChangedTriggerDetail2
  {
    public extern ToastHistoryChangedType ChangeType { [MethodImpl] get; }

    public extern string CollectionId { [MethodImpl] get; }
  }
}
