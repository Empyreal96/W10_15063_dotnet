// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Wallet.NativeWalletItem
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.SecureElement;
using Microsoft.Phone.Storage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Microsoft.Phone.Wallet
{
  internal class NativeWalletItem : IDisposable
  {
    private const int MaxStringPropertyLength = 1024;
    private IntPtr _nativeWalletItem = IntPtr.Zero;
    private WalletItem _managedWalletItem;
    private const int _maxInternalIdLength = 64;
    internal static string _temporaryImagePath = (string) null;
    internal static int _defaultJpegCompression = 90;
    private bool _disposed;

    internal static string TemporaryImagePath
    {
      get
      {
        if (NativeWalletItem._temporaryImagePath == null)
          NativeWalletItem._temporaryImagePath = NativeMethods.GetAppTempDirectory();
        return NativeWalletItem._temporaryImagePath;
      }
    }

    internal WalletItem WalletItem
    {
      get
      {
        if (this._managedWalletItem == null)
          this._managedWalletItem = NativeWalletItem.NativeToManagedWalletItem(this);
        return this._managedWalletItem;
      }
    }

    [SecuritySafeCritical]
    internal NativeWalletItem(WalletItem managedWalletItem)
    {
      if (!managedWalletItem.IsSavedInWallet)
      {
        WalletItemType offerId;
        switch (managedWalletItem)
        {
          case Deal _:
            offerId = WalletItemType.Coupon;
            break;
          case PaymentInstrument _:
            offerId = WalletItemType.PaymentCard;
            break;
          case WalletTransactionItem _:
            offerId = WalletItemType.OtherCard;
            break;
          default:
            throw new ArgumentException(string.Format("Unsupported item type {0}.", (object) managedWalletItem.GetType()));
        }
        NativeHelpers.IfFailedHrThrowException(NativeMethods.CreateWalletItem(offerId, out this._nativeWalletItem));
      }
      else
        NativeHelpers.IfFailedHrThrowException(NativeMethods.GetWalletItemByInternalId(managedWalletItem.InternalId, out this._nativeWalletItem));
      this._managedWalletItem = managedWalletItem;
    }

    [SecuritySafeCritical]
    internal NativeWalletItem(WalletTransaction managedWalletTransaction)
    {
      if (string.IsNullOrEmpty(managedWalletTransaction.OwningItemInternalId))
        throw new ArgumentException();
      if (string.IsNullOrWhiteSpace(managedWalletTransaction.InternalTransactionId))
        NativeHelpers.IfFailedHrThrowException(NativeMethods.CreateTransactionEntry(managedWalletTransaction.OwningItemInternalId, out this._nativeWalletItem));
      else
        NativeHelpers.IfFailedHrThrowException(NativeMethods.GetWalletItemByInternalId(managedWalletTransaction.InternalTransactionId, out this._nativeWalletItem));
      this._managedWalletItem = (WalletItem) managedWalletTransaction.Values;
    }

    internal NativeWalletItem(IntPtr nativePointer) => this._nativeWalletItem = !(nativePointer == IntPtr.Zero) ? nativePointer : throw new ArgumentException("Invalid wallet item");

    ~NativeWalletItem() => this.Dispose(false);

    [SecuritySafeCritical]
    internal int? GetIntProperty(WalletItemPropertyType propertyType)
    {
      int? nullable1 = new int?();
      int num = 0;
      int? nullable2;
      try
      {
        NativeHelpers.IfFailedHrThrowException(NativeMethods.GetWalletItemIntProperty(this._nativeWalletItem, propertyType, out num));
        nullable2 = new int?(num);
      }
      catch (KeyNotFoundException ex)
      {
        nullable2 = new int?();
      }
      return nullable2;
    }

    [SecuritySafeCritical]
    internal byte[] GetBlobProperty(WalletItemPropertyType propertyType)
    {
      byte[] numArray;
      try
      {
        uint cbValue;
        NativeHelpers.IfFailedHrThrowException(NativeMethods.GetWalletItemBlobPropertySize(this._nativeWalletItem, propertyType, out cbValue));
        numArray = new byte[(int) cbValue];
        NativeHelpers.IfFailedHrThrowException(NativeMethods.GetWalletItemBlobProperty(this._nativeWalletItem, propertyType, numArray, ref cbValue));
      }
      catch (KeyNotFoundException ex)
      {
        numArray = (byte[]) null;
      }
      return numArray;
    }

    [SecuritySafeCritical]
    internal string GetStringProperty(WalletItemPropertyType propertyType)
    {
      StringBuilder stringBuilder = new StringBuilder(1024);
      try
      {
        IntPtr nativeWalletItem = this._nativeWalletItem;
        int num = (int) propertyType;
        StringBuilder pszBuffer = stringBuilder;
        int capacity = pszBuffer.Capacity;
        NativeHelpers.IfFailedHrThrowException(NativeMethods.GetWalletItemStringProperty(nativeWalletItem, (WalletItemPropertyType) num, pszBuffer, capacity));
        return stringBuilder.ToString();
      }
      catch (KeyNotFoundException ex)
      {
        return (string) null;
      }
    }

    internal BitmapSource GetImageProperty(WalletItemPropertyType propertyType)
    {
      BitmapSource bitmapSource = (BitmapSource) null;
      string imageTokenId = this.GetImageTokenId(propertyType);
      if (imageTokenId != null)
        bitmapSource = NativeWalletItem.ReadImageFromTokenOnUIThread(imageTokenId);
      return bitmapSource;
    }

    [SecuritySafeCritical]
    internal string GetImageTokenId(WalletItemPropertyType propertyType)
    {
      StringBuilder stringBuilder = new StringBuilder(1024);
      try
      {
        IntPtr nativeWalletItem = this._nativeWalletItem;
        int num = (int) propertyType;
        StringBuilder pszBuffer = stringBuilder;
        int capacity = pszBuffer.Capacity;
        NativeHelpers.IfFailedHrThrowException(NativeMethods.GetWalletItemImageProperty(nativeWalletItem, (WalletItemPropertyType) num, pszBuffer, capacity));
        return stringBuilder.ToString().Replace("dss://", "");
      }
      catch (KeyNotFoundException ex)
      {
        return (string) null;
      }
    }

    internal bool IsImagePropertySet(WalletItemPropertyType propertyType)
    {
      bool flag = false;
      if (this._managedWalletItem != null)
        flag = !this._managedWalletItem.Properties.ContainsKey(propertyType) || !this._managedWalletItem.Properties[propertyType].ValuePendingWrite ? !string.IsNullOrWhiteSpace(this.GetImageTokenId(propertyType)) : this._managedWalletItem.Properties[propertyType].Value != null;
      return flag;
    }

    private static BitmapSource ReadImageFromTokenOnUIThread(string tokenId)
    {
      BitmapSource result = (BitmapSource) null;
      if (Deployment.Current.Dispatcher.CheckAccess())
      {
        using (NativeFileStream nativeFileStream = NativeFileStream.OpenFileFromToken(tokenId))
        {
          BitmapImage bitmapImage = new BitmapImage();
          bitmapImage.SetSource((Stream) nativeFileStream);
          result = (BitmapSource) bitmapImage;
        }
      }
      else
      {
        AutoResetEvent waitEvent = new AutoResetEvent(false);
        Deployment.Current.Dispatcher.BeginInvoke((Action) (() =>
        {
          result = NativeWalletItem.ReadImageFromTokenOnUIThread(tokenId);
          waitEvent.Set();
        }));
        waitEvent.WaitOne();
      }
      return result;
    }

    [SecuritySafeCritical]
    internal CustomWalletProperty GetCustomProperty(string key)
    {
      CustomWalletProperty customWalletProperty = new CustomWalletProperty();
      StringBuilder stringBuilder1 = new StringBuilder(1024);
      StringBuilder stringBuilder2 = new StringBuilder(1024);
      IntPtr nativeWalletItem = this._nativeWalletItem;
      string pszKey = key;
      StringBuilder pszLabel = stringBuilder1;
      int capacity1 = pszLabel.Capacity;
      StringBuilder pszValue = stringBuilder2;
      int capacity2 = pszValue.Capacity;
      NativeHelpers.IfFailedHrThrowException(NativeMethods.GetCustomProperty(nativeWalletItem, pszKey, pszLabel, capacity1, pszValue, capacity2));
      customWalletProperty.Label = stringBuilder1.ToString();
      customWalletProperty.Value = stringBuilder2.ToString();
      return customWalletProperty;
    }

    [SecuritySafeCritical]
    internal WalletItemType GetWalletItemType()
    {
      WalletItemType walletItemType = WalletItemType.Undefined;
      NativeHelpers.IfFailedHrThrowException(NativeMethods.GetWalletItemType(this._nativeWalletItem, out walletItemType));
      return walletItemType;
    }

    [SecuritySafeCritical]
    internal DateTime? GetDateTimeProperty(WalletItemPropertyType propertyType)
    {
      DateTime? nullable1 = new DateTime?();
      DateTime? nullable2;
      try
      {
        long fileTime;
        NativeHelpers.IfFailedHrThrowException(NativeMethods.GetWalletItemFileTimeProperty(this._nativeWalletItem, propertyType, out fileTime));
        nullable2 = new DateTime?(DateTime.FromFileTime(fileTime));
      }
      catch (KeyNotFoundException ex)
      {
        nullable2 = new DateTime?();
      }
      return nullable2;
    }

    protected static WalletItem NativeToManagedWalletItem(NativeWalletItem nativeItem)
    {
      try
      {
        WalletItemType walletItemType1 = nativeItem.GetWalletItemType();
        WalletItemType walletItemType2 = walletItemType1 != WalletItemType.Undefined ? walletItemType1 : throw new NotSupportedException();
        string stringProperty = nativeItem.GetStringProperty(WalletItemPropertyType.AppItemId);
        string internalId = nativeItem.GetInternalId();
        switch (walletItemType2)
        {
          case WalletItemType.PaymentCard:
            PaymentCardKinds paymentCardKinds = PaymentCardKinds.Undefined;
            int? intProperty = nativeItem.GetIntProperty(WalletItemPropertyType.PaymentCardType);
            if (intProperty.HasValue)
              paymentCardKinds = (PaymentCardKinds) intProperty.Value;
            switch (paymentCardKinds & ~PaymentCardKinds.Inicis)
            {
              case PaymentCardKinds.Credit:
              case PaymentCardKinds.Debit:
              case PaymentCardKinds.CreditDebit:
                return (WalletItem) new PaymentInstrument(internalId, stringProperty);
              case PaymentCardKinds.Csv:
              case PaymentCardKinds.PayPal:
              case PaymentCardKinds.AliPay:
              case PaymentCardKinds.MobileOperator:
                return (WalletItem) new OnlinePaymentInstrument(internalId, stringProperty);
              default:
                throw new NotSupportedException();
            }
          case WalletItemType.OtherCard:
            return (WalletItem) new WalletTransactionItem(internalId, stringProperty);
          case WalletItemType.Coupon:
            return (WalletItem) new Deal(internalId, stringProperty);
          case WalletItemType.Transaction:
            return (WalletItem) new WalletTransactionValues(internalId, stringProperty);
          default:
            throw new NotSupportedException();
        }
      }
      catch (NotSupportedException ex)
      {
        return (WalletItem) null;
      }
    }

    [SecuritySafeCritical]
    internal static NativeWalletItem GetById(string appItemId)
    {
      NativeWalletItem nativeWalletItem = (NativeWalletItem) null;
      IntPtr itemContext = IntPtr.Zero;
      int walletItemByAppItemId = NativeMethods.GetWalletItemByAppItemId(appItemId, out itemContext);
      if (walletItemByAppItemId == -2143682560)
        itemContext = IntPtr.Zero;
      else
        NativeHelpers.IfFailedHrThrowException(walletItemByAppItemId);
      if (itemContext != IntPtr.Zero)
        nativeWalletItem = new NativeWalletItem(itemContext);
      return nativeWalletItem;
    }

    [SecuritySafeCritical]
    internal int GetMaxCustomPropertiesAllowed()
    {
      uint maxCustomProperties = 0;
      NativeHelpers.IfFailedHrThrowException(NativeMethods.GetMaxCustomPropertiesAllowed(this._nativeWalletItem, out maxCustomProperties));
      if (maxCustomProperties > (uint) int.MaxValue)
        maxCustomProperties = (uint) int.MaxValue;
      return (int) maxCustomProperties;
    }

    [SecuritySafeCritical]
    internal static NativeWalletItem GetByInternalId(string internalId)
    {
      IntPtr itemContext = IntPtr.Zero;
      try
      {
        NativeHelpers.IfFailedHrThrowException(NativeMethods.GetWalletItemByInternalId(internalId, out itemContext));
        return new NativeWalletItem(itemContext);
      }
      catch (KeyNotFoundException ex)
      {
        return (NativeWalletItem) null;
      }
    }

    [SecuritySafeCritical]
    internal ConfirmAddWalletItemResult AddWalletItem()
    {
      StringBuilder stringBuilder = new StringBuilder(64);
      this.SaveItemProperties(true);
      this.SaveItemCustomProperties(true);
      IntPtr nativeWalletItem = this._nativeWalletItem;
      int num1;
      ref int local = ref num1;
      StringBuilder pszBuffer = stringBuilder;
      int capacity = pszBuffer.Capacity;
      NativeHelpers.IfFailedHrThrowException(NativeMethods.AddWalletItem(nativeWalletItem, out local, pszBuffer, capacity));
      int num2 = num1;
      if (num2 != 2)
        return (ConfirmAddWalletItemResult) num2;
      this._managedWalletItem.ConvertToSavedInternalItemAndAddToWallet(stringBuilder.ToString());
      return (ConfirmAddWalletItemResult) num2;
    }

    [SecuritySafeCritical]
    internal void SaveToWallet()
    {
      this.SaveItemProperties(false);
      this.SaveItemCustomProperties(false);
      this.SaveItemTransactionHistory();
      NativeHelpers.IfFailedHrThrowException(NativeMethods.SaveWalletItem(this._nativeWalletItem));
      if (this._managedWalletItem.IsSavedInWallet)
        return;
      this._managedWalletItem.InternalId = this.GetInternalId();
    }

    [SecuritySafeCritical]
    internal string GetInternalId()
    {
      StringBuilder stringBuilder = new StringBuilder(64);
      IntPtr nativeWalletItem = this._nativeWalletItem;
      StringBuilder pszBuffer = stringBuilder;
      int capacity = pszBuffer.Capacity;
      NativeHelpers.IfFailedHrThrowException(NativeMethods.GetWalletItemInternalId(nativeWalletItem, pszBuffer, capacity));
      return stringBuilder.ToString();
    }

    [SecuritySafeCritical]
    private void SaveItemProperties(bool keepPendingWrite)
    {
      foreach (WalletItemPropertyType key in this._managedWalletItem.Properties.Keys)
      {
        InternalWalletProperty property = this._managedWalletItem.Properties[key];
        if (property.ValuePendingWrite)
        {
          if (property.Value == null)
          {
            try
            {
              NativeHelpers.IfFailedHrThrowException(NativeMethods.DeleteWalletItemProperty(this._nativeWalletItem, key));
            }
            catch (KeyNotFoundException ex)
            {
            }
          }
          else if (property.Value is string || (object) (property.Value as Uri) != null)
          {
            string str = (string) null;
            if (property.Value != null)
              str = property.Value.ToString();
            NativeHelpers.IfFailedHrThrowException(NativeMethods.SetWalletItemStringProperty(this._nativeWalletItem, key, str));
          }
          else if (property.Value is int?)
          {
            int? nullable = property.Value as int?;
            NativeHelpers.IfFailedHrThrowException(NativeMethods.SetWalletItemIntProperty(this._nativeWalletItem, key, nullable.Value));
          }
          else if (property.Value is byte[])
          {
            byte[] numArray1 = property.Value as byte[];
            IntPtr nativeWalletItem = this._nativeWalletItem;
            int num = (int) key;
            byte[] numArray2 = numArray1;
            int length = numArray2.Length;
            NativeHelpers.IfFailedHrThrowException(NativeMethods.SetWalletItemBlobProperty(nativeWalletItem, (WalletItemPropertyType) num, numArray2, length));
          }
          else if (property.Value is PaymentCardKinds?)
          {
            PaymentCardKinds? nullable1 = property.Value as PaymentCardKinds?;
            int? nullable2 = new int?();
            if (nullable1.HasValue)
              nullable2 = new int?((int) nullable1.Value);
            NativeHelpers.IfFailedHrThrowException(NativeMethods.SetWalletItemIntProperty(this._nativeWalletItem, key, nullable2.Value));
          }
          else if (property.Value is bool?)
          {
            bool? nullable1 = property.Value as bool?;
            int? nullable2 = new int?();
            if (nullable1.HasValue)
              nullable2 = new int?(nullable1.Value ? 1 : 0);
            NativeHelpers.IfFailedHrThrowException(NativeMethods.SetWalletItemIntProperty(this._nativeWalletItem, key, nullable2.Value));
          }
          else if (property.Value is DateTime?)
          {
            long fileTime = (property.Value as DateTime?).Value.ToFileTime();
            NativeHelpers.IfFailedHrThrowException(NativeMethods.SetWalletItemFileTimeProperty(this._nativeWalletItem, key, fileTime));
          }
          else
          {
            BitmapSource bmp = property.Value is BitmapSource ? property.Value as BitmapSource : throw new ArgumentException();
            this.SaveImageToDBOnUIThread(key, bmp);
          }
          property.ValuePendingWrite = keepPendingWrite;
        }
      }
    }

    [SecuritySafeCritical]
    private void SaveImageToDBOnUIThread(WalletItemPropertyType type, BitmapSource bmp)
    {
      if (Deployment.Current.Dispatcher.CheckAccess())
      {
        string path = (string) null;
        try
        {
          if (bmp != null)
          {
            WriteableBitmap bitmap = new WriteableBitmap(bmp);
            path = Path.Combine(NativeWalletItem.TemporaryImagePath, Guid.NewGuid().ToString() + ".jpg");
            using (StreamWriter streamWriter = new StreamWriter(path))
              bitmap.SaveJpeg(streamWriter.BaseStream, bitmap.PixelWidth, bitmap.PixelHeight, 0, NativeWalletItem._defaultJpegCompression);
          }
          NativeHelpers.IfFailedHrThrowException(NativeMethods.SetWalletItemImageProperty(this._nativeWalletItem, type, path));
        }
        catch (NullReferenceException ex)
        {
          throw new ArgumentOutOfRangeException("Invalid BitmapSource while saving item to the wallet.  Image download must be complete before save.");
        }
        finally
        {
          if (path != null && File.Exists(path))
            File.Delete(path);
        }
      }
      else
      {
        AutoResetEvent waitEvent = new AutoResetEvent(false);
        Deployment.Current.Dispatcher.BeginInvoke((Action) (() =>
        {
          this.SaveImageToDBOnUIThread(type, bmp);
          waitEvent.Set();
        }));
        waitEvent.WaitOne();
      }
    }

    private void SaveItemCustomProperties(bool keepPendingWrite)
    {
      if (!(this._managedWalletItem.CustomProperties is CustomWalletPropertyDictionary customProperties))
        return;
      Dictionary<string, CustomWalletProperty> propertiesPendingDelete = customProperties.PropertiesPendingDelete;
      Dictionary<string, CustomWalletProperty> properties = customProperties.Properties;
      this.SaveCachedMultiFieldProperties<CustomWalletProperty>(propertiesPendingDelete, keepPendingWrite);
      this.SaveCachedMultiFieldProperties<CustomWalletProperty>(properties, keepPendingWrite);
    }

    private void SaveItemTransactionHistory()
    {
      if (!(this._managedWalletItem is WalletTransactionItemBase managedWalletItem) || !(managedWalletItem.TransactionHistory is WalletTransactionDictionary transactionHistory))
        return;
      Dictionary<string, WalletTransaction> propertiesPendingDelete = transactionHistory.PropertiesPendingDelete;
      Dictionary<string, WalletTransaction> properties = transactionHistory.Properties;
      this.SaveCachedMultiFieldProperties<WalletTransaction>(propertiesPendingDelete, false);
      this.SaveCachedMultiFieldProperties<WalletTransaction>(properties, false);
    }

    [SecuritySafeCritical]
    private void SaveCachedMultiFieldProperties<T>(
      Dictionary<string, T> cachedProperties,
      bool keepPendingWrite)
      where T : WalletPropertyBase
    {
      foreach (string key in cachedProperties.Keys)
      {
        T cachedProperty = cachedProperties[key];
        if (cachedProperty.HasPendingWrite)
        {
          if (typeof (T) == typeof (CustomWalletProperty))
          {
            CustomWalletProperty customWalletProperty = (object) cachedProperty as CustomWalletProperty;
            NativeHelpers.IfFailedHrThrowException(NativeMethods.SetCustomProperty(this._nativeWalletItem, key, customWalletProperty.Label, customWalletProperty.Value));
          }
          else if (typeof (T) == typeof (WalletTransaction))
          {
            WalletTransaction managedWalletTransaction = (object) cachedProperty as WalletTransaction;
            if (managedWalletTransaction.IsMarkedForDeletion)
            {
              NativeHelpers.IfFailedHrThrowException(NativeMethods.DeleteTransactionEntry(managedWalletTransaction.InternalKey));
            }
            else
            {
              using (NativeWalletItem nativeWalletItem = new NativeWalletItem(managedWalletTransaction))
              {
                nativeWalletItem.WalletItem.UpdateId(key);
                nativeWalletItem.SaveToWallet();
              }
            }
          }
          cachedProperty.HasPendingWrite = keepPendingWrite;
        }
      }
    }

    [SecuritySafeCritical]
    internal void DeleteItemFromWallet()
    {
      NativeHelpers.IfFailedHrThrowException(NativeMethods.DeleteWalletItem(this._nativeWalletItem));
      if (this._managedWalletItem == null)
        return;
      this._managedWalletItem.InternalId = (string) null;
    }

    [SecuritySafeCritical]
    internal void SetNotification(InternalNotificationType notificationType) => NativeHelpers.IfFailedHrThrowException(NativeMethods.AddWalletItemNotification(this._nativeWalletItem, notificationType));

    [SecuritySafeCritical]
    internal bool ItemHasUserAttentionRequired()
    {
      bool itemHasUserAttentionRequired = false;
      NativeHelpers.IfFailedHrThrowException(NativeMethods.ItemHasUserAttentionRequired(this._nativeWalletItem, out itemHasUserAttentionRequired));
      return itemHasUserAttentionRequired;
    }

    [SecuritySafeCritical]
    internal string[] GetCustomPropertyKeys()
    {
      string[] keys = (string[]) null;
      int customPropertyKeys = NativeMethods.GetCustomPropertyKeys(this._nativeWalletItem, ref keys);
      if (customPropertyKeys == -2143682560)
        keys = new string[0];
      else
        NativeHelpers.IfFailedHrThrowException(customPropertyKeys);
      return keys;
    }

    [SecuritySafeCritical]
    internal WalletItemUsages GetItemAbilities()
    {
      int dwAbilities = 0;
      NativeHelpers.IfFailedHrThrowException(NativeMethods.GetItemAbilities(this._nativeWalletItem, out dwAbilities));
      return (WalletItemUsages) dwAbilities;
    }

    [SecuritySafeCritical]
    internal void UpdateAppItemId(string newId) => NativeHelpers.IfFailedHrThrowException(NativeMethods.UpdateAppItemId(this._nativeWalletItem, newId));

    [SecuritySafeCritical]
    internal void WriteAgentResultData(int result, string transactionAmount)
    {
      if (!this._managedWalletItem.IsSavedInWallet)
        return;
      NativeHelpers.IfFailedHrThrowException(NativeMethods.SetWalletItemIntProperty(this._nativeWalletItem, WalletItemPropertyType.AgentReturnData, result));
      if (transactionAmount != null)
        NativeHelpers.IfFailedHrThrowException(NativeMethods.SetWalletItemStringProperty(this._nativeWalletItem, WalletItemPropertyType.AgentReturnTransactionAmount, transactionAmount));
      else
        NativeMethods.DeleteWalletItemProperty(this._nativeWalletItem, WalletItemPropertyType.AgentReturnTransactionAmount);
      NativeHelpers.IfFailedHrThrowException(NativeMethods.SaveWalletItem(this._nativeWalletItem));
    }

    [SecuritySafeCritical]
    internal void ActivationAuthenticationCompleted(ActivationAuthenticationResultKind result)
    {
      if (!this._managedWalletItem.IsSavedInWallet)
        throw new InvalidOperationException("Item must be saved in the wallet.");
      if (!Enum.IsDefined(typeof (ActivationAuthenticationResultKind), (object) result))
        throw new ArgumentOutOfRangeException("Not a valid result");
      NativeHelpers.IfFailedHrThrowException(NativeMethods.ActivationAuthenticationCompleted(this._nativeWalletItem, (int) result));
    }

    [SecuritySafeCritical]
    internal List<WalletTransaction> GetWalletTransactions()
    {
      List<WalletTransaction> walletTransactionList = new List<WalletTransaction>();
      if (this._managedWalletItem.IsSavedInWallet)
      {
        IntPtr listContext;
        NativeHelpers.IfFailedHrThrowException(NativeMethods.GetTransactionsForWalletItem(this._nativeWalletItem, out listContext));
        if (listContext != IntPtr.Zero)
        {
          using (NativeWalletItemList nativeWalletItemList = new NativeWalletItemList(listContext))
          {
            if (nativeWalletItemList != null)
            {
              int count = nativeWalletItemList.Count;
              for (uint index = 0; (long) index < (long) count; ++index)
                walletTransactionList.Add(nativeWalletItemList.GetWalletTransactionAt(index));
            }
          }
        }
      }
      return walletTransactionList;
    }

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    [SecuritySafeCritical]
    protected virtual void Dispose(bool disposing)
    {
      if (this._disposed)
        return;
      int num = disposing ? 1 : 0;
      if (this._nativeWalletItem != IntPtr.Zero)
      {
        NativeMethods.FreeWalletItem(this._nativeWalletItem);
        this._nativeWalletItem = IntPtr.Zero;
      }
      this._disposed = true;
    }
  }
}
