// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyLicenseIterableFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3558317832, 2103, 18808, 142, 104, 190, 66, 147, 200, 215, 166)]
  [ExclusiveTo(typeof (PlayReadyLicenseIterable))]
  internal interface IPlayReadyLicenseIterableFactory
  {
    PlayReadyLicenseIterable CreateInstance(
      PlayReadyContentHeader contentHeader,
      bool fullyEvaluated);
  }
}
