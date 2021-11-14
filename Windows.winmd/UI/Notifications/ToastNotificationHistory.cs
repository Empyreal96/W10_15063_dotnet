// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ToastNotificationHistory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class ToastNotificationHistory : 
    IToastNotificationHistory,
    IToastNotificationHistory2
  {
    [Overload("RemoveGroup")]
    [MethodImpl]
    public extern void RemoveGroup(string group);

    [Overload("RemoveGroupWithId")]
    [MethodImpl]
    public extern void RemoveGroup(string group, string applicationId);

    [Overload("RemoveGroupedTagWithId")]
    [MethodImpl]
    public extern void Remove(string tag, string group, string applicationId);

    [Overload("RemoveGroupedTag")]
    [MethodImpl]
    public extern void Remove(string tag, string group);

    [Overload("Remove")]
    [MethodImpl]
    public extern void Remove(string tag);

    [Overload("Clear")]
    [MethodImpl]
    public extern void Clear();

    [Overload("ClearWithId")]
    [MethodImpl]
    public extern void Clear(string applicationId);

    [Overload("GetHistory")]
    [MethodImpl]
    public extern IVectorView<ToastNotification> GetHistory();

    [Overload("GetHistoryWithId")]
    [MethodImpl]
    public extern IVectorView<ToastNotification> GetHistory(
      string applicationId);
  }
}
