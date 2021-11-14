// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.ProductLicense
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ProductLicense : IProductLicense, IProductLicenseWithFulfillment
  {
    public extern string ProductId { [MethodImpl] get; }

    public extern bool IsActive { [MethodImpl] get; }

    public extern DateTime ExpirationDate { [MethodImpl] get; }

    public extern bool IsConsumable { [MethodImpl] get; }
  }
}
