// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.LockScreen.ILockApplicationHostStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.LockScreen
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (LockApplicationHost))]
  [Guid(4103056270, 9175, 20067, 150, 161, 102, 111, 245, 45, 59, 44)]
  internal interface ILockApplicationHostStatics
  {
    LockApplicationHost GetForCurrentView();
  }
}
