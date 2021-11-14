// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IAdaptiveNotificationText
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (AdaptiveNotificationText))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1188340670, 24730, 17190, 164, 11, 191, 222, 135, 32, 52, 163)]
  internal interface IAdaptiveNotificationText : IAdaptiveNotificationContent
  {
    string Text { get; set; }

    string Language { get; set; }
  }
}
