// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.VolumeInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  public sealed class VolumeInfo : IVolumeInfo
  {
    public extern uint SystemVolume { [MethodImpl] get; }

    public extern uint CallVolume { [MethodImpl] get; }

    public extern uint MediaVolume { [MethodImpl] get; }

    public extern bool IsMuted { [MethodImpl] get; }

    public extern VibrateState IsVibrateEnabled { [MethodImpl] get; }
  }
}
