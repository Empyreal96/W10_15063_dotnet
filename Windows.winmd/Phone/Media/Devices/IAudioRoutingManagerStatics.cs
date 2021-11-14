// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Media.Devices.IAudioRoutingManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Media.Devices
{
  [Guid(2541728420, 21904, 19055, 173, 222, 106, 61, 10, 213, 130, 80)]
  [ExclusiveTo(typeof (AudioRoutingManager))]
  [ContractVersion(typeof (PhoneContract), 65536)]
  internal interface IAudioRoutingManagerStatics
  {
    AudioRoutingManager GetDefault();
  }
}
