// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactChangeTracker
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1855531346, 12443, 16461, 151, 18, 179, 123, 211, 2, 120, 170)]
  [ExclusiveTo(typeof (ContactChangeTracker))]
  internal interface IContactChangeTracker
  {
    void Enable();

    ContactChangeReader GetChangeReader();

    void Reset();
  }
}
