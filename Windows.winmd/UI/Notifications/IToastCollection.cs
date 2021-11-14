// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (ToastCollection))]
  [Guid(176931760, 57534, 18520, 188, 42, 137, 223, 224, 179, 40, 99)]
  internal interface IToastCollection
  {
    string Id { get; }

    string DisplayName { get; set; }

    string LaunchArgs { get; set; }

    Uri Icon { get; set; }
  }
}
