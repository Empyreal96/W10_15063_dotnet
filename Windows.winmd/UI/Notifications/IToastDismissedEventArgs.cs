// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastDismissedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Guid(1065998645, 55755, 17720, 160, 240, 255, 231, 101, 153, 56, 248)]
  [ExclusiveTo(typeof (ToastDismissedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IToastDismissedEventArgs
  {
    ToastDismissalReason Reason { get; }
  }
}
