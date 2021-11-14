// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.UserControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [global::Windows.UI.Xaml.Markup.ContentProperty(Name = "Content")]
  [Composable(typeof (IUserControlFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IUserControlStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public class UserControl : Control, IUserControl
  {
    [MethodImpl]
    public extern UserControl();

    public extern UIElement Content { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty ContentProperty { [MethodImpl] get; }
  }
}
