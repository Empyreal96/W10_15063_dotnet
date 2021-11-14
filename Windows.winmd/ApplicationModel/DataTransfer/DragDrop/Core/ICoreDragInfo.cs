// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DragDrop.Core.ICoreDragInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer.DragDrop.Core
{
  [ExclusiveTo(typeof (CoreDragInfo))]
  [WebHostHidden]
  [Guid(1211447947, 52048, 17998, 149, 117, 205, 78, 58, 122, 176, 40)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICoreDragInfo
  {
    DataPackageView Data { get; }

    DragDropModifiers Modifiers { get; }

    Point Position { get; }
  }
}
