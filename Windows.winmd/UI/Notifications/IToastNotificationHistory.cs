// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastNotificationHistory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ToastNotificationHistory))]
  [Guid(1554898019, 467, 19607, 152, 111, 5, 51, 72, 63, 238, 20)]
  internal interface IToastNotificationHistory
  {
    [Overload("RemoveGroup")]
    void RemoveGroup(string group);

    [Overload("RemoveGroupWithId")]
    void RemoveGroup(string group, string applicationId);

    [Overload("RemoveGroupedTagWithId")]
    void Remove(string tag, string group, string applicationId);

    [Overload("RemoveGroupedTag")]
    void Remove(string tag, string group);

    [Overload("Remove")]
    void Remove(string tag);

    [Overload("Clear")]
    void Clear();

    [Overload("ClearWithId")]
    void Clear(string applicationId);
  }
}
