// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactPicker
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactPicker))]
  [Guid(235535761, 17144, 16469, 144, 160, 137, 111, 150, 115, 137, 54)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContactPicker
  {
    string CommitButtonText { get; set; }

    ContactSelectionMode SelectionMode { get; set; }

    IVector<string> DesiredFields { get; }

    IAsyncOperation<ContactInformation> PickSingleContactAsync();

    IAsyncOperation<IVectorView<ContactInformation>> PickMultipleContactsAsync();
  }
}
