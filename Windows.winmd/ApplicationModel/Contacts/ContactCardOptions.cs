// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactCardOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ContactCardOptions : IContactCardOptions, IContactCardOptions2
  {
    [MethodImpl]
    public extern ContactCardOptions();

    public extern ContactCardHeaderKind HeaderKind { [MethodImpl] get; [MethodImpl] set; }

    public extern ContactCardTabKind InitialTabKind { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<string> ServerSearchContactListIds { [MethodImpl] get; }
  }
}
