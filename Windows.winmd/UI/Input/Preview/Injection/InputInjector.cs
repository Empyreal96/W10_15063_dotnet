// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.InputInjector
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  [Static(typeof (IInputInjectorStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class InputInjector : IInputInjector
  {
    [MethodImpl]
    public extern void InjectKeyboardInput(IIterable<InjectedInputKeyboardInfo> input);

    [MethodImpl]
    public extern void InjectMouseInput(IIterable<InjectedInputMouseInfo> input);

    [MethodImpl]
    public extern void InitializeTouchInjection(InjectedInputVisualizationMode visualMode);

    [MethodImpl]
    public extern void InjectTouchInput(IIterable<InjectedInputTouchInfo> input);

    [MethodImpl]
    public extern void UninitializeTouchInjection();

    [MethodImpl]
    public extern void InitializePenInjection(InjectedInputVisualizationMode visualMode);

    [MethodImpl]
    public extern void InjectPenInput(InjectedInputPenInfo input);

    [MethodImpl]
    public extern void UninitializePenInjection();

    [MethodImpl]
    public extern void InjectShortcut(InjectedInputShortcut shortcut);

    [MethodImpl]
    public static extern InputInjector TryCreate();
  }
}
