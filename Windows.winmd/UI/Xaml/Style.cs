// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Style
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IStyleFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContentProperty(Name = "Setters")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class Style : DependencyObject, IStyle
  {
    [MethodImpl]
    public extern Style(TypeName targetType);

    [MethodImpl]
    public extern Style();

    public extern bool IsSealed { [MethodImpl] get; }

    public extern SetterBaseCollection Setters { [MethodImpl] get; }

    public extern TypeName TargetType { [MethodImpl] get; [MethodImpl] set; }

    public extern Style BasedOn { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void Seal();
  }
}
