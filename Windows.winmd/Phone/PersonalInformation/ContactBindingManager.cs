// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.ContactBindingManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.PersonalInformation
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ContactBindingManager : IClosable, IContactBindingManager
  {
    [MethodImpl]
    public extern void Close();

    [MethodImpl]
    public extern ContactBinding CreateContactBinding(string RemoteId);

    [MethodImpl]
    public extern IAsyncOperation<ContactBinding> CreateOrOpenMeContactBindingAsync(
      string RemoteId);

    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ContactBinding>> GetContactBindingsAsync();

    [MethodImpl]
    public extern IAsyncOperation<ContactBinding> GetContactBindingByRemoteIdAsync(
      string RemoteId);

    [MethodImpl]
    public extern IAsyncOperation<ContactBinding> GetContactBindingFromStoredContactAsync(
      string ContactId);

    [MethodImpl]
    public extern IAsyncAction SaveContactBindingAsync(ContactBinding binding);

    [MethodImpl]
    public extern IAsyncAction DeleteContactBindingAsync(ContactBinding binding);

    [MethodImpl]
    public extern IAsyncAction DeleteAllContactBindingsAsync();

    [MethodImpl]
    public extern IAsyncAction CreateContactBindingTileAsync(
      string LocalContext,
      ContactBinding binding);
  }
}
