// Decompiled with JetBrains decompiler
// Type: Windows.Phone.System.UserProfile.ILockScreenManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.System.UserProfile
{
  [ExclusiveTo(typeof (LockScreenManager))]
  [Guid(3679783149, 39181, 20225, 143, 204, 28, 198, 3, 233, 16, 178)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  internal interface ILockScreenManagerStatics
  {
    bool IsProvidedByCurrentApplication { get; }

    IAsyncOperation<LockScreenRequestResult> RequestAccessAsync();
  }
}
