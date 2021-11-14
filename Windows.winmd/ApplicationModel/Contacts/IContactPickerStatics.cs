// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactPickerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(1955119145, 27219, 16984, 163, 233, 98, 223, 246, 120, 75, 108)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (ContactPicker))]
  internal interface IContactPickerStatics
  {
    ContactPicker CreateForUser(User user);

    [RemoteAsync]
    IAsyncOperation<bool> IsSupportedAsync();
  }
}
