// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.StoreAppLicense
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (StoreContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class StoreAppLicense : IStoreAppLicense
  {
    public extern string SkuStoreId { [MethodImpl] get; }

    public extern bool IsActive { [MethodImpl] get; }

    public extern bool IsTrial { [MethodImpl] get; }

    public extern DateTime ExpirationDate { [MethodImpl] get; }

    public extern string ExtendedJsonData { [MethodImpl] get; }

    public extern IMapView<string, StoreLicense> AddOnLicenses { [MethodImpl] get; }

    public extern TimeSpan TrialTimeRemaining { [MethodImpl] get; }

    public extern bool IsTrialOwnedByThisUser { [MethodImpl] get; }

    public extern string TrialUniqueId { [MethodImpl] get; }
  }
}
