// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.DragStartingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DragStartingEventArgs : 
    RoutedEventArgs,
    IDragStartingEventArgs,
    IDragStartingEventArgs2
  {
    public extern bool Cancel { [MethodImpl] get; [MethodImpl] set; }

    public extern DataPackage Data { [MethodImpl] get; }

    public extern DragUI DragUI { [MethodImpl] get; }

    [MethodImpl]
    public extern DragOperationDeferral GetDeferral();

    [MethodImpl]
    public extern Point GetPosition(UIElement relativeTo);

    public extern DataPackageOperation AllowedOperations { [MethodImpl] get; [MethodImpl] set; }
  }
}
