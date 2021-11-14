// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactManagerStatics4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactManager))]
  [Guid(613950066, 13435, 18140, 141, 149, 81, 189, 65, 225, 90, 175)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IContactManagerStatics4
  {
    ContactManagerForUser GetForUser(User user);
  }
}
