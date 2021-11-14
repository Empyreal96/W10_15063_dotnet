// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.PhoneNotificationType
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  public enum PhoneNotificationType
  {
    NewCall,
    CallChanged,
    LineChanged,
    PhoneCallAudioEndpointChanged,
    PhoneMuteChanged,
  }
}
