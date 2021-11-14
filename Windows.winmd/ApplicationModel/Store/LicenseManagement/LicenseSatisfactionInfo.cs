// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.LicenseManagement.LicenseSatisfactionInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.LicenseManagement
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class LicenseSatisfactionInfo : ILicenseSatisfactionInfo
  {
    public extern bool SatisfiedByDevice { [MethodImpl] get; }

    public extern bool SatisfiedByOpenLicense { [MethodImpl] get; }

    public extern bool SatisfiedByTrial { [MethodImpl] get; }

    public extern bool SatisfiedByPass { [MethodImpl] get; }

    public extern bool SatisfiedByInstallMedia { [MethodImpl] get; }

    public extern bool SatisfiedBySignedInUser { [MethodImpl] get; }

    public extern bool IsSatisfied { [MethodImpl] get; }
  }
}
