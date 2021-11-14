// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Setter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (ISetterFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class Setter : SetterBase, ISetter, ISetter2
  {
    [MethodImpl]
    public extern Setter(DependencyProperty targetProperty, object value);

    [MethodImpl]
    public extern Setter();

    public extern DependencyProperty Property { [MethodImpl] get; [MethodImpl] set; }

    public extern object Value { [MethodImpl] get; [MethodImpl] set; }

    public extern TargetPropertyPath Target { [MethodImpl] get; [MethodImpl] set; }
  }
}
