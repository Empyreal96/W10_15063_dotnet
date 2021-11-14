// Decompiled with JetBrains decompiler
// Type: Windows.Phone.System.UserProfile.ILockScreenStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.System.UserProfile
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [ExclusiveTo(typeof (LockScreen))]
  [Guid(2323871273, 13360, 16660, 156, 101, 13, 199, 131, 163, 27, 115)]
  internal interface ILockScreenStatics
  {
    Uri GetImageUri();

    void SetImageUri(Uri value);
  }
}
