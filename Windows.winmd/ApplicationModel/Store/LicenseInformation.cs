// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.LicenseInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class LicenseInformation : ILicenseInformation
  {
    public extern IMapView<string, ProductLicense> ProductLicenses { [MethodImpl] get; }

    public extern bool IsActive { [MethodImpl] get; }

    public extern bool IsTrial { [MethodImpl] get; }

    public extern DateTime ExpirationDate { [MethodImpl] get; }

    public extern event LicenseChangedEventHandler LicenseChanged;
  }
}
