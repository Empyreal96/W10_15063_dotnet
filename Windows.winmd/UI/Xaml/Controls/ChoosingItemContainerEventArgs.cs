// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ChoosingItemContainerEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class ChoosingItemContainerEventArgs : IChoosingItemContainerEventArgs
  {
    [MethodImpl]
    public extern ChoosingItemContainerEventArgs();

    public extern int ItemIndex { [MethodImpl] get; }

    public extern object Item { [MethodImpl] get; }

    public extern SelectorItem ItemContainer { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsContainerPrepared { [MethodImpl] get; [MethodImpl] set; }
  }
}
