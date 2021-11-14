// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.IMuteChangeRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  [Guid(3837064694, 44831, 20254, 180, 55, 125, 163, 36, 0, 225, 212)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MuteChangeRequestedEventArgs))]
  internal interface IMuteChangeRequestedEventArgs
  {
    bool Mute { get; }
  }
}
