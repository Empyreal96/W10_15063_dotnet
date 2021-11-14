// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.IVolumeInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [ExclusiveTo(typeof (VolumeInfo))]
  [Guid(2488127768, 30468, 17537, 185, 46, 211, 237, 62, 206, 99, 34)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  internal interface IVolumeInfo
  {
    uint SystemVolume { get; }

    uint CallVolume { get; }

    uint MediaVolume { get; }

    bool IsMuted { get; }

    VibrateState IsVibrateEnabled { get; }
  }
}
