// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.DragEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.DataTransfer;
using Windows.ApplicationModel.DataTransfer.DragDrop;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class DragEventArgs : 
    RoutedEventArgs,
    IDragEventArgs,
    IDragEventArgs2,
    IDragEventArgs3
  {
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }

    public extern DataPackage Data { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern Point GetPosition(UIElement relativeTo);

    public extern DataPackageView DataView { [MethodImpl] get; }

    public extern DragUIOverride DragUIOverride { [MethodImpl] get; }

    public extern DragDropModifiers Modifiers { [MethodImpl] get; }

    public extern DataPackageOperation AcceptedOperation { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern DragOperationDeferral GetDeferral();

    public extern DataPackageOperation AllowedOperations { [MethodImpl] get; }
  }
}
