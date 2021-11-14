// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.RadioButton
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [Static(typeof (IRadioButtonStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IRadioButtonFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public class RadioButton : ToggleButton, IRadioButton
  {
    [MethodImpl]
    public extern RadioButton();

    public extern string GroupName { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty GroupNameProperty { [MethodImpl] get; }
  }
}
