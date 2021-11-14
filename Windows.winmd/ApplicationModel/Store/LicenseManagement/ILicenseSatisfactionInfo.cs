// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.LicenseManagement.ILicenseSatisfactionInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.LicenseManagement
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (LicenseSatisfactionInfo))]
  [Guid(1019981967, 56113, 18645, 131, 132, 250, 23, 200, 20, 116, 226)]
  internal interface ILicenseSatisfactionInfo
  {
    bool SatisfiedByDevice { get; }

    bool SatisfiedByOpenLicense { get; }

    bool SatisfiedByTrial { get; }

    bool SatisfiedByPass { get; }

    bool SatisfiedByInstallMedia { get; }

    bool SatisfiedBySignedInUser { get; }

    bool IsSatisfied { get; }
  }
}
