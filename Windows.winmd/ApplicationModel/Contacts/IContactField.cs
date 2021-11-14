// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactField
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2977319018, 53907, 18732, 160, 88, 219, 87, 91, 62, 60, 15)]
  public interface IContactField
  {
    ContactFieldType Type { get; }

    ContactFieldCategory Category { get; }

    string Name { get; }

    string Value { get; }
  }
}
