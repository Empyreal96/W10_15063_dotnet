// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Networking.Voip.IMuteChangeEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Networking.Voip
{
  [Guid(4178897620, 7316, 17804, 172, 183, 25, 38, 162, 51, 247, 76)]
  [ExclusiveTo(typeof (MuteChangeEventArgs))]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  internal interface IMuteChangeEventArgs
  {
    bool Muted { get; }
  }
}
