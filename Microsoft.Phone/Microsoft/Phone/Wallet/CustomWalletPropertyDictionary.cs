// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Wallet.CustomWalletPropertyDictionary
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Collections.Generic;

namespace Microsoft.Phone.Wallet
{
  internal class CustomWalletPropertyDictionary : WalletPropertyDictionaryBase<CustomWalletProperty>
  {
    internal readonly int MaxPropertiesAllowed;

    protected override int MaxPropertiesAllowedInDictionary => this.MaxPropertiesAllowed;

    internal CustomWalletPropertyDictionary(WalletItem owner)
      : base(owner)
    {
      using (NativeWalletItem nativeWalletItem = new NativeWalletItem(owner))
        this.MaxPropertiesAllowed = nativeWalletItem.GetMaxCustomPropertiesAllowed();
    }

    internal override List<CustomWalletProperty> GetFreshListFromDB()
    {
      List<CustomWalletProperty> customWalletPropertyList = new List<CustomWalletProperty>();
      foreach (string key in this.OwnerItem.GetCustomPropertyKeysFromNativeItem())
        customWalletPropertyList.Add(new CustomWalletProperty(this.OwnerItem, key));
      return customWalletPropertyList;
    }
  }
}
