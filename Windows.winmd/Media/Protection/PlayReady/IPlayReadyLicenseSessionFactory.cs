// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyLicenseSessionFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ExclusiveTo(typeof (PlayReadyLicenseSession))]
  [Guid(1648961177, 25895, 17054, 152, 190, 72, 215, 152, 172, 39, 57)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPlayReadyLicenseSessionFactory
  {
    PlayReadyLicenseSession CreateInstance(IPropertySet configuration);
  }
}
