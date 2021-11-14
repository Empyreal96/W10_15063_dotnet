// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.PushNotificationTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  [Activatable(typeof (IPushNotificationTriggerFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class PushNotificationTrigger : IBackgroundTrigger
  {
    [MethodImpl]
    public extern PushNotificationTrigger(string applicationId);

    [MethodImpl]
    public extern PushNotificationTrigger();
  }
}
