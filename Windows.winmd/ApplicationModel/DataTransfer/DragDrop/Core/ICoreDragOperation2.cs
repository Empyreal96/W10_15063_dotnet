// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DragDrop.Core.ICoreDragOperation2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer.DragDrop.Core
{
  [ExclusiveTo(typeof (CoreDragOperation))]
  [Guid(2185961004, 55706, 20419, 133, 7, 108, 24, 47, 51, 180, 106)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ICoreDragOperation2 : ICoreDragOperation
  {
    DataPackageOperation AllowedOperations { get; set; }
  }
}
