// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactPicker
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IContactPickerStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ContactPicker : IContactPicker, IContactPicker2, IContactPicker3
  {
    [MethodImpl]
    public extern ContactPicker();

    public extern string CommitButtonText { [MethodImpl] get; [MethodImpl] set; }

    public extern ContactSelectionMode SelectionMode { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<string> DesiredFields { [MethodImpl] get; }

    [MethodImpl]
    public extern IAsyncOperation<ContactInformation> PickSingleContactAsync();

    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ContactInformation>> PickMultipleContactsAsync();

    public extern IVector<ContactFieldType> DesiredFieldsWithContactFieldType { [MethodImpl] get; }

    [MethodImpl]
    public extern IAsyncOperation<Contact> PickContactAsync();

    [MethodImpl]
    public extern IAsyncOperation<IVector<Contact>> PickContactsAsync();

    public extern User User { [MethodImpl] get; }

    [MethodImpl]
    public static extern ContactPicker CreateForUser(User user);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> IsSupportedAsync();
  }
}
