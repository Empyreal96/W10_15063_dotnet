// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.PinnedContactManager
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
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IPinnedContactManagerStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class PinnedContactManager : IPinnedContactManager
  {
    public extern User User { [MethodImpl] get; }

    [MethodImpl]
    public extern bool IsPinSurfaceSupported(PinnedContactSurface surface);

    [MethodImpl]
    public extern bool IsContactPinned(Contact contact, PinnedContactSurface surface);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestPinContactAsync(
      Contact contact,
      PinnedContactSurface surface);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestPinContactsAsync(
      IIterable<Contact> contacts,
      PinnedContactSurface surface);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestUnpinContactAsync(
      Contact contact,
      PinnedContactSurface surface);

    [MethodImpl]
    public extern void SignalContactActivity(Contact contact);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PinnedContactIdsQueryResult> GetPinnedContactIdsAsync();

    [MethodImpl]
    public static extern PinnedContactManager GetDefault();

    [MethodImpl]
    public static extern PinnedContactManager GetForUser(User user);

    [MethodImpl]
    public static extern bool IsSupported();
  }
}
