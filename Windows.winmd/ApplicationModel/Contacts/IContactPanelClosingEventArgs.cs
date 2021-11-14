// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactPanelClosingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(572617939, 53067, 18135, 183, 57, 110, 220, 22, 17, 11, 251)]
  [ExclusiveTo(typeof (ContactPanelClosingEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IContactPanelClosingEventArgs
  {
    Deferral GetDeferral();
  }
}
