// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.DynamicOverflowItemsChangingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class DynamicOverflowItemsChangingEventArgs : IDynamicOverflowItemsChangingEventArgs
  {
    [MethodImpl]
    public extern DynamicOverflowItemsChangingEventArgs();

    public extern CommandBarDynamicOverflowAction Action { [MethodImpl] get; }
  }
}
