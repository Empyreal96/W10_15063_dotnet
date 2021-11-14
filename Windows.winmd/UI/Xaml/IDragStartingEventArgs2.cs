// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDragStartingEventArgs2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [Guid(3629506702, 17590, 16913, 189, 11, 127, 221, 187, 110, 130, 49)]
  [ExclusiveTo(typeof (DragStartingEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IDragStartingEventArgs2
  {
    DataPackageOperation AllowedOperations { get; set; }
  }
}
