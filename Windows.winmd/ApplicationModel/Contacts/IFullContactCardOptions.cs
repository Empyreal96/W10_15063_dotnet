// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IFullContactCardOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.ViewManagement;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(2269397868, 23801, 18051, 189, 202, 161, 253, 235, 248, 219, 206)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FullContactCardOptions))]
  internal interface IFullContactCardOptions
  {
    ViewSizePreference DesiredRemainingView { get; set; }
  }
}
