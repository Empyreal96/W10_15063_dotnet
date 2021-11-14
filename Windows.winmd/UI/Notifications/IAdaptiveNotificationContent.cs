// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IAdaptiveNotificationContent
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3943546470, 29768, 17549, 157, 184, 215, 138, 205, 42, 187, 169)]
  public interface IAdaptiveNotificationContent
  {
    AdaptiveNotificationContentKind Kind { get; }

    IMap<string, string> Hints { get; }
  }
}
