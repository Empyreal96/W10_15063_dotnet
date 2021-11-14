// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.BindingExpression
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IBindingExpressionFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public class BindingExpression : BindingExpressionBase, IBindingExpression
  {
    public extern object DataItem { [MethodImpl] get; }

    public extern Binding ParentBinding { [MethodImpl] get; }

    [MethodImpl]
    public extern void UpdateSource();
  }
}
