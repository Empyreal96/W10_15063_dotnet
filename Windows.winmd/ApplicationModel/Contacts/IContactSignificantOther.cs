// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactSignificantOther
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(2289284523, 50683, 18136, 147, 254, 218, 63, 241, 147, 64, 84)]
  [ExclusiveTo(typeof (ContactSignificantOther))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContactSignificantOther
  {
    string Name { get; set; }

    string Description { get; set; }
  }
}
