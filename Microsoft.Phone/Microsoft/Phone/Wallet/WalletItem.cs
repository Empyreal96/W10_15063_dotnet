// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Wallet.WalletItem
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Tasks;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Microsoft.Phone.Wallet
{
  public abstract class WalletItem
  {
    private string _internalId;
    private Dictionary<WalletItemPropertyType, InternalWalletProperty> _properties = new Dictionary<WalletItemPropertyType, InternalWalletProperty>();
    private CustomWalletPropertyDictionary _customProperties;

    internal WalletItem()
    {
      this.Initialize();
      this.SetId(Guid.NewGuid().ToString());
    }

    internal WalletItem(string id)
    {
      this.Initialize();
      this.SetId(id);
    }

    internal WalletItem(string internalId, string id)
    {
      this.InternalId = internalId;
      this.Initialize();
      this.SetId(id);
    }

    internal virtual void Initialize()
    {
      switch (this)
      {
        case Deal _:
        case PaymentInstrument _:
        case OnlinePaymentInstrument _:
        case WalletTransactionItem _:
          this._customProperties = new CustomWalletPropertyDictionary(this);
          break;
      }
    }

    public string Id => this.GetStringPropertyFromNativeItem(WalletItemPropertyType.AppItemId);

    public void UpdateId(string newId)
    {
      if (string.IsNullOrWhiteSpace(newId))
        throw new ArgumentNullException("id cannot be null or only whitespace");
      if (!(this.Id != newId))
        return;
      if (this.IsSavedInWallet)
      {
        using (NativeWalletItem nativeWalletItem = new NativeWalletItem(this))
          nativeWalletItem.UpdateAppItemId(newId);
      }
      else
        this.SetId(newId);
    }

    internal void SetId(string id) => this.GetWalletProperty<string>(WalletItemPropertyType.AppItemId).Value = id;

    internal string InternalId
    {
      get => this._internalId;
      set => this._internalId = value;
    }

    internal bool IsSavedInWallet
    {
      get
      {
        bool flag = false;
        if (this.InternalId != null)
        {
          using (NativeWalletItem byInternalId = NativeWalletItem.GetByInternalId(this.InternalId))
            flag = byInternalId != null;
        }
        return flag;
      }
    }

    internal Dictionary<WalletItemPropertyType, InternalWalletProperty> Properties => this._properties;

    public IDictionary<string, CustomWalletProperty> CustomProperties => (IDictionary<string, CustomWalletProperty>) this._customProperties;

    internal void EnsureRequiredPropertiesAreSet() => this.ThrowIfRequiredPropertiesNotSet();

    internal void ThrowIfValueNotSet<T>(T value, string propertyName) where T : class
    {
      bool hasValue = false;
      if ((object) value != null)
        hasValue = !((object) value is string) || !string.IsNullOrWhiteSpace((object) value as string);
      this.ThrowIfValueIsFalse(hasValue, propertyName);
    }

    internal void ThrowIfValueIsFalse(bool hasValue, string propertyName)
    {
      if (!hasValue)
        throw new InvalidOperationException(!string.IsNullOrEmpty(propertyName) ? "'" + propertyName + "' needs to be set before this item can be saved" : "All required fields need to be set before this item can be saved");
    }

    internal virtual void ThrowIfRequiredPropertiesNotSet() => this.ThrowIfValueNotSet<string>(this.ItemSpecificName.Value, "DisplayName");

    internal bool AnyPropertiesChanged(List<InternalWalletProperty> properties)
    {
      bool flag = false;
      foreach (InternalWalletProperty property in properties)
      {
        InternalWalletProperty internalWalletProperty = (InternalWalletProperty) null;
        if (this.Properties.ContainsKey(property.PropertyType))
          internalWalletProperty = this.Properties[property.PropertyType];
        if (internalWalletProperty != null && internalWalletProperty.ValuePendingWrite)
        {
          flag = true;
          break;
        }
      }
      return flag;
    }

    public Uri NavigationUri
    {
      get => new Uri(this.GetWalletProperty<string>(WalletItemPropertyType.AppNavigationUri).Value, UriKind.Relative);
      set
      {
        this.EnsureRelativeUri(value);
        this.GetWalletProperty<string>(WalletItemPropertyType.AppNavigationUri).Value = value.ToString();
      }
    }

    internal void EnsureRelativeUri(Uri uri)
    {
      if (uri != (Uri) null && uri.IsAbsoluteUri)
        throw new ArgumentException("Uri must be a relative Uri");
    }

    internal void EnsureAbsoluteUriWithHttpScheme(Uri uri)
    {
      if (uri != (Uri) null && (!uri.IsAbsoluteUri || uri.Scheme != "http" && uri.Scheme != "https"))
        throw new ArgumentException("Uri must be absolute, with scheme http or https");
    }

    public string Notes
    {
      get => this.GetWalletProperty<string>(WalletItemPropertyType.Notes).Value;
      set => this.GetWalletProperty<string>(WalletItemPropertyType.Notes).Value = value;
    }

    public string IssuerName
    {
      get => this.GetWalletProperty<string>(WalletItemPropertyType.Issuer).Value;
      set => this.GetWalletProperty<string>(WalletItemPropertyType.Issuer).Value = value;
    }

    public Uri IssuerWebsite
    {
      get => this.GetWalletProperty<Uri>(WalletItemPropertyType.IssuerUri).Value;
      set
      {
        this.EnsureAbsoluteUriWithHttpScheme(value);
        this.GetWalletProperty<Uri>(WalletItemPropertyType.IssuerUri).Value = value;
      }
    }

    public BitmapSource BarcodeImage
    {
      get => this.GetWalletProperty<BitmapSource>(WalletItemPropertyType.BarcodeImage).Value;
      set => this.GetWalletProperty<BitmapSource>(WalletItemPropertyType.BarcodeImage).Value = value;
    }

    public BitmapSource UserImage
    {
      get => this.GetWalletProperty<BitmapSource>(WalletItemPropertyType.UserImage).Value;
      set => this.GetWalletProperty<BitmapSource>(WalletItemPropertyType.UserImage).Value = value;
    }

    public DateTime? LastUpdated
    {
      get => this.GetWalletProperty<DateTime?>(WalletItemPropertyType.DataValidAsOf).Value;
      set => this.GetWalletProperty<DateTime?>(WalletItemPropertyType.DataValidAsOf).Value = value;
    }

    public string Message
    {
      get => this.GetWalletProperty<string>(WalletItemPropertyType.AppStatusMessage).Value;
      set => this.GetWalletProperty<string>(WalletItemPropertyType.AppStatusMessage).Value = value;
    }

    public Uri MessageNavigationUri
    {
      get => new Uri(this.GetWalletProperty<string>(WalletItemPropertyType.AppStatusMessageUri).Value, UriKind.Relative);
      set
      {
        this.EnsureRelativeUri(value);
        this.GetWalletProperty<string>(WalletItemPropertyType.AppStatusMessageUri).Value = value.ToString();
      }
    }

    internal InternalWalletProperty<TValue> GetWalletProperty<TValue>(
      WalletItemPropertyType propertyType)
    {
      return this.GetWalletProperty<TValue>(propertyType, (ValueValidationHandler) null);
    }

    internal InternalWalletProperty<TValue> GetWalletProperty<TValue>(
      WalletItemPropertyType propertyType,
      ValueValidationHandler valueValidationHandler)
    {
      InternalWalletProperty<TValue> internalWalletProperty;
      if (this.Properties.ContainsKey(propertyType))
      {
        internalWalletProperty = this.Properties[propertyType] as InternalWalletProperty<TValue>;
      }
      else
      {
        internalWalletProperty = new InternalWalletProperty<TValue>(this, propertyType);
        if (valueValidationHandler != null)
          internalWalletProperty.ValueSet += valueValidationHandler;
        this.Properties.Add(propertyType, (InternalWalletProperty) internalWalletProperty);
      }
      return internalWalletProperty;
    }

    internal string GetStringPropertyFromNativeItem(WalletItemPropertyType propertyType)
    {
      string str = (string) null;
      if (this.IsSavedInWallet)
      {
        using (NativeWalletItem byInternalId = NativeWalletItem.GetByInternalId(this._internalId))
        {
          if (byInternalId != null)
            str = byInternalId.GetStringProperty(propertyType);
        }
      }
      return str;
    }

    internal BitmapSource GetImagePropertyFromNativeItem(
      WalletItemPropertyType propertyType)
    {
      BitmapSource bitmapSource = (BitmapSource) null;
      if (this.IsSavedInWallet)
      {
        using (NativeWalletItem byInternalId = NativeWalletItem.GetByInternalId(this._internalId))
        {
          if (byInternalId != null)
            bitmapSource = byInternalId.GetImageProperty(propertyType);
        }
      }
      return bitmapSource;
    }

    internal DateTime? GetDateTimePropertyFromNativeItem(WalletItemPropertyType propertyType)
    {
      DateTime? nullable = new DateTime?();
      if (this.IsSavedInWallet)
      {
        using (NativeWalletItem byInternalId = NativeWalletItem.GetByInternalId(this._internalId))
        {
          if (byInternalId != null)
            nullable = byInternalId.GetDateTimeProperty(propertyType);
        }
      }
      return nullable;
    }

    internal int? GetIntPropertyFromNativeItem(WalletItemPropertyType propertyType)
    {
      int? nullable = new int?();
      if (this.IsSavedInWallet)
      {
        using (NativeWalletItem byInternalId = NativeWalletItem.GetByInternalId(this._internalId))
        {
          if (byInternalId != null)
            nullable = byInternalId.GetIntProperty(propertyType);
        }
      }
      return nullable;
    }

    internal byte[] GetBlobPropertyFromNativeItem(WalletItemPropertyType propertyType)
    {
      byte[] numArray = (byte[]) null;
      if (this.IsSavedInWallet)
      {
        using (NativeWalletItem byInternalId = NativeWalletItem.GetByInternalId(this._internalId))
        {
          if (byInternalId != null)
            numArray = byInternalId.GetBlobProperty(propertyType);
        }
      }
      return numArray;
    }

    internal CustomWalletProperty GetCustomPropertyFromNativeItem(string key)
    {
      CustomWalletProperty customWalletProperty = new CustomWalletProperty();
      if (this.IsSavedInWallet)
      {
        using (NativeWalletItem byInternalId = NativeWalletItem.GetByInternalId(this._internalId))
        {
          if (byInternalId != null)
            customWalletProperty = byInternalId.GetCustomProperty(key);
        }
      }
      return customWalletProperty;
    }

    internal string[] GetCustomPropertyKeysFromNativeItem()
    {
      string[] strArray = (string[]) null;
      if (this.IsSavedInWallet)
      {
        using (NativeWalletItem byInternalId = NativeWalletItem.GetByInternalId(this._internalId))
        {
          if (byInternalId != null)
            strArray = byInternalId.GetCustomPropertyKeys();
        }
      }
      else
        strArray = new string[0];
      return strArray;
    }

    public void Undo()
    {
      if (!this.IsSavedInWallet)
        return;
      this.RestoreToUntouchedItem();
    }

    internal void RestoreToUntouchedItem() => this.ClearPropertyCaches();

    internal void ResetItem() => this.Initialize();

    internal void ConvertToSavedInternalItem(string internalId)
    {
      if (this.IsSavedInWallet)
        return;
      this.InternalId = internalId;
      if (this.InternalId == null)
        return;
      this.RestoreToUntouchedItem();
    }

    internal void ConvertToSavedInternalItemAndAddToWallet(string internalId) => this.ConvertToSavedInternalItem(internalId);

    internal virtual void ClearPropertyCaches()
    {
      this.Properties.Clear();
      this._customProperties.RefreshCacheFromDB();
    }

    internal void Save()
    {
      this.SaveItem();
      this.ClearPropertyCaches();
    }

    public Task SaveAsync() => new TaskFactory().StartNew((Action) (() => this.Save()));

    internal void SaveItem()
    {
      if (!this.IsSavedInWallet && AddWalletItemTask.AddWalletItemTaskRequired(this))
        throw new ArgumentException("item must be added via the AddWalletItemTask");
      this.EnsureRequiredPropertiesAreSet();
      using (NativeWalletItem nativeWalletItem = new NativeWalletItem(this))
        nativeWalletItem.SaveToWallet();
      this.RestoreToUntouchedItem();
    }

    public bool IsUserAttentionRequired
    {
      get
      {
        using (NativeWalletItem nativeWalletItem = new NativeWalletItem(this))
          return nativeWalletItem.ItemHasUserAttentionRequired();
      }
    }

    public void SetUserAttentionRequiredNotification(bool setNotification)
    {
      NotificationType notificationType1 = setNotification ? NotificationType.AttentionRequired : NotificationType.None;
      InternalNotificationType notificationType2 = InternalNotificationType.Undefined;
      switch (notificationType1)
      {
        case NotificationType.None:
          notificationType2 = InternalNotificationType.Undefined;
          break;
        case NotificationType.AttentionRequired:
          notificationType2 = InternalNotificationType.AppItemAttentionRequired;
          break;
      }
      using (NativeWalletItem nativeWalletItem = new NativeWalletItem(this))
        nativeWalletItem.SetNotification(notificationType2);
    }

    public string CustomerName
    {
      get => this.GetWalletProperty<string>(WalletItemPropertyType.CardholderName).Value;
      set => this.GetWalletProperty<string>(WalletItemPropertyType.CardholderName).Value = value;
    }

    public BitmapSource Logo99x99
    {
      get => this.GetWalletProperty<BitmapSource>(WalletItemPropertyType.BrandImageSmall).Value;
      set => this.GetWalletProperty<BitmapSource>(WalletItemPropertyType.BrandImageSmall).Value = value;
    }

    public BitmapSource Logo159x159
    {
      get => this.GetWalletProperty<BitmapSource>(WalletItemPropertyType.BrandImageMedium).Value;
      set => this.GetWalletProperty<BitmapSource>(WalletItemPropertyType.BrandImageMedium).Value = value;
    }

    public BitmapSource Logo336x336
    {
      get => this.GetWalletProperty<BitmapSource>(WalletItemPropertyType.BrandImageLarge).Value;
      set => this.GetWalletProperty<BitmapSource>(WalletItemPropertyType.BrandImageLarge).Value = value;
    }

    internal abstract InternalWalletProperty<string> ItemSpecificName { get; }

    public string DisplayName
    {
      get => this.ItemSpecificName.Value;
      set => this.ItemSpecificName.Value = value;
    }

    public bool IsAcknowledged
    {
      get
      {
        int? nullable = this.GetWalletProperty<int?>(WalletItemPropertyType.AppLinkState).Value;
        nullable = new int?(nullable.GetValueOrDefault(3));
        int num = 3;
        return nullable.GetValueOrDefault() == num && nullable.HasValue;
      }
      set
      {
        int? nullable = new int?(value ? 3 : 2);
        this.GetWalletProperty<int?>(WalletItemPropertyType.AppLinkState).Value = nullable;
      }
    }
  }
}
