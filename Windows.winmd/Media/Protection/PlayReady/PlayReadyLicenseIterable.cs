// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.PlayReadyLicenseIterable
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IPlayReadyLicenseIterableFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class PlayReadyLicenseIterable : IIterable<IPlayReadyLicense>
  {
    [MethodImpl]
    public extern PlayReadyLicenseIterable();

    [MethodImpl]
    public extern PlayReadyLicenseIterable(
      PlayReadyContentHeader contentHeader,
      bool fullyEvaluated);

    [MethodImpl]
    public extern IIterator<IPlayReadyLicense> First();
  }
}
