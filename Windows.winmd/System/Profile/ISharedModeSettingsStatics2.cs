// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.ISharedModeSettingsStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  [Guid(1619626148, 52465, 20200, 165, 226, 253, 106, 29, 12, 250, 200)]
  [ContractVersion(typeof (ProfileSharedModeContract), 131072)]
  [ExclusiveTo(typeof (SharedModeSettings))]
  internal interface ISharedModeSettingsStatics2
  {
    bool ShouldAvoidLocalStorage { get; }
  }
}
