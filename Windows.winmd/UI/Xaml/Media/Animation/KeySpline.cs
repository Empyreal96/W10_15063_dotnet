// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.KeySpline
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class KeySpline : DependencyObject, IKeySpline
  {
    [MethodImpl]
    public extern KeySpline();

    public extern Point ControlPoint1 { [MethodImpl] get; [MethodImpl] set; }

    public extern Point ControlPoint2 { [MethodImpl] get; [MethodImpl] set; }
  }
}
