// Decompiled with JetBrains decompiler
// Type: Windows.Media.Casting.ICastingDeviceSelectedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Casting
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3695419014, 56663, 19725, 148, 0, 175, 69, 228, 251, 54, 99)]
  [ExclusiveTo(typeof (CastingDeviceSelectedEventArgs))]
  internal interface ICastingDeviceSelectedEventArgs
  {
    CastingDevice SelectedCastingDevice { get; }
  }
}
