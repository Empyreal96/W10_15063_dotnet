// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.StoreSubscriptionInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (StoreContract), 65536)]
  public sealed class StoreSubscriptionInfo : IStoreSubscriptionInfo
  {
    public extern uint BillingPeriod { [MethodImpl] get; }

    public extern StoreDurationUnit BillingPeriodUnit { [MethodImpl] get; }

    public extern bool HasTrialPeriod { [MethodImpl] get; }

    public extern uint TrialPeriod { [MethodImpl] get; }

    public extern StoreDurationUnit TrialPeriodUnit { [MethodImpl] get; }
  }
}
