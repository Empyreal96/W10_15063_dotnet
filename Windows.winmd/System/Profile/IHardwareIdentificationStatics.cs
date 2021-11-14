// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.IHardwareIdentificationStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.System.Profile
{
  [Guid(2534564064, 61808, 19010, 189, 85, 169, 0, 178, 18, 218, 226)]
  [ContractVersion(typeof (ProfileHardwareTokenContract), 65536)]
  [ExclusiveTo(typeof (HardwareIdentification))]
  internal interface IHardwareIdentificationStatics
  {
    HardwareToken GetPackageSpecificToken(IBuffer nonce);
  }
}
