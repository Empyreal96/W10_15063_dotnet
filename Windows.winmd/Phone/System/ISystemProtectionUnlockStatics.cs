// Decompiled with JetBrains decompiler
// Type: Windows.Phone.System.ISystemProtectionUnlockStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.System
{
  [Guid(110295615, 36625, 19531, 170, 13, 135, 215, 175, 123, 23, 121)]
  [ExclusiveTo(typeof (SystemProtection))]
  [ContractVersion(typeof (PhoneContract), 65536)]
  internal interface ISystemProtectionUnlockStatics
  {
    void RequestScreenUnlock();
  }
}
