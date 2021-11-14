// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ItemsPickedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class ItemsPickedEventArgs : DependencyObject, IItemsPickedEventArgs
  {
    [MethodImpl]
    public extern ItemsPickedEventArgs();

    public extern IVector<object> AddedItems { [MethodImpl] get; }

    public extern IVector<object> RemovedItems { [MethodImpl] get; }
  }
}
