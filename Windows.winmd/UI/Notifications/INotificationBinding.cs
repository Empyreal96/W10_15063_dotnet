// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.INotificationBinding
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Guid(4070460293, 880, 19155, 180, 234, 218, 158, 53, 231, 234, 191)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (NotificationBinding))]
  internal interface INotificationBinding
  {
    string Template { get; set; }

    string Language { get; set; }

    IMap<string, string> Hints { get; }

    IVectorView<AdaptiveNotificationText> GetTextElements();
  }
}
