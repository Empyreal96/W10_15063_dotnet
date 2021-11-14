// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.ProductPurchaseDisplayProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [Activatable(typeof (IProductPurchaseDisplayPropertiesFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ProductPurchaseDisplayProperties : IProductPurchaseDisplayProperties
  {
    [MethodImpl]
    public extern ProductPurchaseDisplayProperties(string name);

    [MethodImpl]
    public extern ProductPurchaseDisplayProperties();

    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    public extern string Description { [MethodImpl] get; [MethodImpl] set; }

    public extern Uri Image { [MethodImpl] get; [MethodImpl] set; }
  }
}
