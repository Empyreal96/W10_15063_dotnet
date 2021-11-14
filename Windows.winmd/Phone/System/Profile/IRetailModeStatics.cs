// Decompiled with JetBrains decompiler
// Type: Windows.Phone.System.Profile.IRetailModeStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.System.Profile
{
  [Guid(3621703721, 64986, 17383, 147, 251, 229, 58, 182, 232, 158, 195)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Deprecated("Use Windows.System.Profile.IRetailInfoStatics instead.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneContract")]
  [ExclusiveTo(typeof (RetailMode))]
  internal interface IRetailModeStatics
  {
    bool RetailModeEnabled { [Deprecated("Use Windows.System.Profile.IRetailInfoStatics instead.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneContract")] get; }
  }
}
