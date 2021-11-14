// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.DragItemsStartingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class DragItemsStartingEventArgs : IDragItemsStartingEventArgs
  {
    [MethodImpl]
    public extern DragItemsStartingEventArgs();

    public extern bool Cancel { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<object> Items { [MethodImpl] get; }

    public extern DataPackage Data { [MethodImpl] get; }
  }
}
