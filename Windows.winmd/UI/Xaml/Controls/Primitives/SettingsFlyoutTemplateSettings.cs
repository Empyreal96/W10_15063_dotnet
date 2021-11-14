// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.SettingsFlyoutTemplateSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SettingsFlyoutTemplateSettings : 
    DependencyObject,
    ISettingsFlyoutTemplateSettings
  {
    public extern Brush HeaderBackground { [MethodImpl] get; }

    public extern Brush HeaderForeground { [MethodImpl] get; }

    public extern Brush BorderBrush { [MethodImpl] get; }

    public extern Thickness BorderThickness { [MethodImpl] get; }

    public extern ImageSource IconSource { [MethodImpl] get; }

    public extern TransitionCollection ContentTransitions { [MethodImpl] get; }
  }
}
