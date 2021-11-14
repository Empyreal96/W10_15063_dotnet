// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDragStartingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1744884730, 37048, 18169, 142, 48, 90, 194, 95, 115, 240, 249)]
  [ExclusiveTo(typeof (DragStartingEventArgs))]
  [WebHostHidden]
  internal interface IDragStartingEventArgs
  {
    bool Cancel { get; set; }

    DataPackage Data { get; }

    DragUI DragUI { get; }

    DragOperationDeferral GetDeferral();

    Point GetPosition(UIElement relativeTo);
  }
}
