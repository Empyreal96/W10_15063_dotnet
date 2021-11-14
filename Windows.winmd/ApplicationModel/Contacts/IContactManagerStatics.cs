// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2180127424, 63073, 18184, 186, 79, 211, 134, 189, 13, 98, 46)]
  [ExclusiveTo(typeof (ContactManager))]
  internal interface IContactManagerStatics
  {
    [Overload("ShowContactCard")]
    void ShowContactCard(Contact contact, Rect selection);

    [Overload("ShowContactCardWithPlacement")]
    void ShowContactCard(Contact contact, Rect selection, Placement preferredPlacement);

    [Overload("ShowDelayLoadedContactCard")]
    ContactCardDelayedDataLoader ShowDelayLoadedContactCard(
      Contact contact,
      Rect selection,
      Placement preferredPlacement);
  }
}
