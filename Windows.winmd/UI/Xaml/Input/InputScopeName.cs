// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.InputScopeName
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Input
{
  [Threading(ThreadingModel.Both)]
  [ContentProperty(Name = "NameValue")]
  [Activatable(typeof (IInputScopeNameFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class InputScopeName : DependencyObject, IInputScopeName
  {
    [MethodImpl]
    public extern InputScopeName(InputScopeNameValue nameValue);

    [MethodImpl]
    public extern InputScopeName();

    public extern InputScopeNameValue NameValue { [MethodImpl] get; [MethodImpl] set; }
  }
}
