// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactCardOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactCardOptions))]
  [Guid(2349485950, 27318, 20287, 190, 114, 129, 114, 54, 238, 234, 91)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContactCardOptions
  {
    ContactCardHeaderKind HeaderKind { get; set; }

    ContactCardTabKind InitialTabKind { get; set; }
  }
}
