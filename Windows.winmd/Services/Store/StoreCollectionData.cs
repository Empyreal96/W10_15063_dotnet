// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.StoreCollectionData
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [ContractVersion(typeof (StoreContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class StoreCollectionData : IStoreCollectionData
  {
    public extern bool IsTrial { [MethodImpl] get; }

    public extern string CampaignId { [MethodImpl] get; }

    public extern string DeveloperOfferId { [MethodImpl] get; }

    public extern DateTime AcquiredDate { [MethodImpl] get; }

    public extern DateTime StartDate { [MethodImpl] get; }

    public extern DateTime EndDate { [MethodImpl] get; }

    public extern TimeSpan TrialTimeRemaining { [MethodImpl] get; }

    public extern string ExtendedJsonData { [MethodImpl] get; }
  }
}
