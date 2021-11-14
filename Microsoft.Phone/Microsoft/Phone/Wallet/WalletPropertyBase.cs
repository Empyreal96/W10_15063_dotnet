// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Wallet.WalletPropertyBase
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

namespace Microsoft.Phone.Wallet
{
  public abstract class WalletPropertyBase
  {
    private bool _hasPendingWrite;

    internal WalletItem OwnerItem { get; private set; }

    internal string Key { get; set; }

    internal WalletPropertyBase() => this.OwnerItem = (WalletItem) null;

    internal WalletPropertyBase(WalletItem ownerItem, string key) => this.AssignOwnership(ownerItem, key);

    internal void AssignOwnership(WalletItem ownerItem, string key)
    {
      this.OwnerItem = ownerItem;
      this.Key = key;
    }

    internal void Disown()
    {
      this.OwnerItem = (WalletItem) null;
      this.Key = (string) null;
    }

    internal abstract bool IsEmpty { get; }

    internal abstract string InternalKey { get; set; }

    internal bool HasPendingWrite
    {
      get => this._hasPendingWrite;
      set => this._hasPendingWrite = value;
    }

    internal bool IsMarkedForDeletion { get; set; }

    internal virtual void MarkForDeletion()
    {
      this.HasPendingWrite = true;
      this.IsMarkedForDeletion = true;
    }

    internal static T CreateDeletedProperty<T>(WalletPropertyBase originalProperty) where T : WalletPropertyBase, new()
    {
      T obj = new T();
      obj.MarkForDeletion();
      obj.OwnerItem = originalProperty.OwnerItem;
      obj.Key = originalProperty.Key;
      obj.InternalKey = originalProperty.InternalKey;
      return obj;
    }
  }
}
