// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.RelativeSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IRelativeSourceFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public class RelativeSource : DependencyObject, IRelativeSource
  {
    [MethodImpl]
    public extern RelativeSource();

    public extern RelativeSourceMode Mode { [MethodImpl] get; [MethodImpl] set; }
  }
}
