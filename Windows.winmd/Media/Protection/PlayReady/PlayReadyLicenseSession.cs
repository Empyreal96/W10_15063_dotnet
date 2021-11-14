// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.PlayReadyLicenseSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [Activatable(typeof (IPlayReadyLicenseSessionFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PlayReadyLicenseSession : IPlayReadyLicenseSession, IPlayReadyLicenseSession2
  {
    [MethodImpl]
    public extern PlayReadyLicenseSession(IPropertySet configuration);

    [MethodImpl]
    public extern IPlayReadyLicenseAcquisitionServiceRequest CreateLAServiceRequest();

    [MethodImpl]
    public extern void ConfigureMediaProtectionManager(MediaProtectionManager mpm);

    [MethodImpl]
    public extern PlayReadyLicenseIterable CreateLicenseIterable(
      PlayReadyContentHeader contentHeader,
      bool fullyEvaluated);
  }
}
