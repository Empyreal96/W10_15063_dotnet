// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.RangeBaseValueChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class RangeBaseValueChangedEventArgs : 
    RoutedEventArgs,
    IRangeBaseValueChangedEventArgs
  {
    public extern double OldValue { [MethodImpl] get; }

    public extern double NewValue { [MethodImpl] get; }
  }
}
