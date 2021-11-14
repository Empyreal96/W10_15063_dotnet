// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.StorePurchaseProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (StoreContract), 65536)]
  [Activatable(typeof (IStorePurchasePropertiesFactory), 65536, "Windows.Services.Store.StoreContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Services.Store.StoreContract")]
  public sealed class StorePurchaseProperties : IStorePurchaseProperties
  {
    [MethodImpl]
    public extern StorePurchaseProperties(string name);

    [MethodImpl]
    public extern StorePurchaseProperties();

    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    public extern string ExtendedJsonData { [MethodImpl] get; [MethodImpl] set; }
  }
}
