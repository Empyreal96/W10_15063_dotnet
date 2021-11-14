// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.IStoreSubscriptionInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [Guid(1099528042, 1369, 17324, 169, 198, 58, 176, 1, 31, 184, 235)]
  [ContractVersion(typeof (StoreContract), 65536)]
  [ExclusiveTo(typeof (StoreSubscriptionInfo))]
  internal interface IStoreSubscriptionInfo
  {
    uint BillingPeriod { get; }

    StoreDurationUnit BillingPeriodUnit { get; }

    bool HasTrialPeriod { get; }

    uint TrialPeriod { get; }

    StoreDurationUnit TrialPeriodUnit { get; }
  }
}
