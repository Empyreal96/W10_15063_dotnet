// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.Binding
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Composable(typeof (IBindingFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class Binding : BindingBase, IBinding, IBinding2
  {
    [MethodImpl]
    public extern Binding();

    public extern PropertyPath Path { [MethodImpl] get; [MethodImpl] set; }

    public extern BindingMode Mode { [MethodImpl] get; [MethodImpl] set; }

    public extern object Source { [MethodImpl] get; [MethodImpl] set; }

    public extern RelativeSource RelativeSource { [MethodImpl] get; [MethodImpl] set; }

    public extern string ElementName { [MethodImpl] get; [MethodImpl] set; }

    public extern IValueConverter Converter { [MethodImpl] get; [MethodImpl] set; }

    public extern object ConverterParameter { [MethodImpl] get; [MethodImpl] set; }

    public extern string ConverterLanguage { [MethodImpl] get; [MethodImpl] set; }

    public extern object FallbackValue { [MethodImpl] get; [MethodImpl] set; }

    public extern object TargetNullValue { [MethodImpl] get; [MethodImpl] set; }

    public extern UpdateSourceTrigger UpdateSourceTrigger { [MethodImpl] get; [MethodImpl] set; }
  }
}
