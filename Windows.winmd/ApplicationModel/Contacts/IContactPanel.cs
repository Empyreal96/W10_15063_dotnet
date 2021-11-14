// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactPanel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(1103041125, 53998, 19351, 168, 10, 125, 141, 100, 204, 166, 245)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (ContactPanel))]
  internal interface IContactPanel
  {
    void ClosePanel();

    IReference<Color> HeaderColor { get; set; }

    event TypedEventHandler<ContactPanel, ContactPanelLaunchFullAppRequestedEventArgs> LaunchFullAppRequested;

    event TypedEventHandler<ContactPanel, ContactPanelClosingEventArgs> Closing;
  }
}
