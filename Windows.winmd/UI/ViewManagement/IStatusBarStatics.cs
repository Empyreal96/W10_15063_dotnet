// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IStatusBarStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;
using Windows.Phone;

namespace Windows.UI.ViewManagement
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  [ExclusiveTo(typeof (StatusBar))]
  [Guid(2336636895, 16943, 17761, 136, 6, 251, 18, 137, 202, 223, 183)]
  internal interface IStatusBarStatics
  {
    StatusBar GetForCurrentView();
  }
}
