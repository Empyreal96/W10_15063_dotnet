// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyLicenseSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2708617785, 34810, 20445, 171, 187, 169, 114, 14, 132, 82, 89)]
  public interface IPlayReadyLicenseSession
  {
    IPlayReadyLicenseAcquisitionServiceRequest CreateLAServiceRequest();

    void ConfigureMediaProtectionManager(MediaProtectionManager mpm);
  }
}
