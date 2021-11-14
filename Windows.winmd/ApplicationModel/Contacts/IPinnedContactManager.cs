// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IPinnedContactManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PinnedContactManager))]
  [Guid(4240208908, 57814, 17859, 184, 182, 163, 86, 4, 225, 103, 160)]
  internal interface IPinnedContactManager
  {
    User User { get; }

    bool IsPinSurfaceSupported(PinnedContactSurface surface);

    bool IsContactPinned(Contact contact, PinnedContactSurface surface);

    [RemoteAsync]
    IAsyncOperation<bool> RequestPinContactAsync(
      Contact contact,
      PinnedContactSurface surface);

    [RemoteAsync]
    IAsyncOperation<bool> RequestPinContactsAsync(
      IIterable<Contact> contacts,
      PinnedContactSurface surface);

    [RemoteAsync]
    IAsyncOperation<bool> RequestUnpinContactAsync(
      Contact contact,
      PinnedContactSurface surface);

    void SignalContactActivity(Contact contact);

    [RemoteAsync]
    IAsyncOperation<PinnedContactIdsQueryResult> GetPinnedContactIdsAsync();
  }
}
