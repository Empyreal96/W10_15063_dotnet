// Decompiled with JetBrains decompiler
// Type: Windows.Phone.System.ISystemProtectionStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.System
{
  [ExclusiveTo(typeof (SystemProtection))]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Guid(1237542240, 38881, 19865, 139, 251, 190, 254, 170, 106, 206, 109)]
  internal interface ISystemProtectionStatics
  {
    bool ScreenLocked { get; }
  }
}
