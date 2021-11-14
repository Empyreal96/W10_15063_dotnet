// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastNotification2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2650513361, 5178, 18702, 144, 191, 185, 251, 167, 19, 45, 231)]
  [ExclusiveTo(typeof (ToastNotification))]
  internal interface IToastNotification2
  {
    string Tag { set; get; }

    string Group { set; get; }

    bool SuppressPopup { set; get; }
  }
}
