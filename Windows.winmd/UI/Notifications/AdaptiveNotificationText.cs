// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.AdaptiveNotificationText
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class AdaptiveNotificationText : 
    IAdaptiveNotificationText,
    IAdaptiveNotificationContent
  {
    [MethodImpl]
    public extern AdaptiveNotificationText();

    public extern string Text { [MethodImpl] get; [MethodImpl] set; }

    public extern string Language { [MethodImpl] get; [MethodImpl] set; }

    public extern AdaptiveNotificationContentKind Kind { [MethodImpl] get; }

    public extern IMap<string, string> Hints { [MethodImpl] get; }
  }
}
