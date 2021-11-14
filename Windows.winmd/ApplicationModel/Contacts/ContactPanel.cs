// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactPanel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.ApplicationModel.Contacts
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class ContactPanel : IContactPanel
  {
    [MethodImpl]
    public extern void ClosePanel();

    public extern IReference<Color> HeaderColor { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<ContactPanel, ContactPanelLaunchFullAppRequestedEventArgs> LaunchFullAppRequested;

    public extern event TypedEventHandler<ContactPanel, ContactPanelClosingEventArgs> Closing;
  }
}
