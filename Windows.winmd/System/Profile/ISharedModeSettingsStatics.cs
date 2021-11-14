// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.ISharedModeSettingsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  [ExclusiveTo(typeof (SharedModeSettings))]
  [Guid(2302538766, 51926, 19792, 140, 73, 111, 207, 192, 62, 219, 41)]
  [ContractVersion(typeof (ProfileSharedModeContract), 65536)]
  internal interface ISharedModeSettingsStatics
  {
    bool IsEnabled { get; }
  }
}
