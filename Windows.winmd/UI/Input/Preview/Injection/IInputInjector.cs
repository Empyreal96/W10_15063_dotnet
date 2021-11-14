// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.IInputInjector
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  [ExclusiveTo(typeof (InputInjector))]
  [Guid(2395107204, 2818, 19410, 173, 122, 61, 70, 88, 190, 62, 24)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IInputInjector
  {
    void InjectKeyboardInput(IIterable<InjectedInputKeyboardInfo> input);

    void InjectMouseInput(IIterable<InjectedInputMouseInfo> input);

    void InitializeTouchInjection(InjectedInputVisualizationMode visualMode);

    void InjectTouchInput(IIterable<InjectedInputTouchInfo> input);

    void UninitializeTouchInjection();

    void InitializePenInjection(InjectedInputVisualizationMode visualMode);

    void InjectPenInput(InjectedInputPenInfo input);

    void UninitializePenInjection();

    void InjectShortcut(InjectedInputShortcut shortcut);
  }
}
