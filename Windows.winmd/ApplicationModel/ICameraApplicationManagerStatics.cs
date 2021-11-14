// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ICameraApplicationManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;
using Windows.Phone;

namespace Windows.ApplicationModel
{
  [ExclusiveTo(typeof (CameraApplicationManager))]
  [Guid(2509888974, 39891, 17244, 128, 84, 193, 173, 213, 0, 40, 254)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  internal interface ICameraApplicationManagerStatics
  {
    void ShowInstalledApplicationsUI();
  }
}
