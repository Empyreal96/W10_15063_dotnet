// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Media.Devices.AvailableAudioRoutingEndpoints
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Media.Devices
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Flags]
  public enum AvailableAudioRoutingEndpoints : uint
  {
    None = 0,
    Earpiece = 1,
    Speakerphone = 2,
    Bluetooth = 4,
  }
}
