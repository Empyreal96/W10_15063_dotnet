// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDragEventArgs2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.DataTransfer;
using Windows.ApplicationModel.DataTransfer.DragDrop;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DragEventArgs))]
  [Guid(640902744, 10519, 16669, 191, 195, 47, 34, 71, 28, 187, 231)]
  [WebHostHidden]
  internal interface IDragEventArgs2
  {
    DataPackageView DataView { get; }

    DragUIOverride DragUIOverride { get; }

    DragDropModifiers Modifiers { get; }

    DataPackageOperation AcceptedOperation { get; set; }

    DragOperationDeferral GetDeferral();
  }
}
