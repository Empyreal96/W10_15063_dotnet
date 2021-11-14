// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1381924817, 29683, 19325, 169, 24, 88, 11, 228, 54, 97, 33)]
  internal interface IContactChangedEventArgs
  {
    ContactChangedDeferral GetDeferral();
  }
}
