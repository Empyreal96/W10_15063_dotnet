// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ComboBoxTemplateSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ComboBoxTemplateSettings : 
    DependencyObject,
    IComboBoxTemplateSettings,
    IComboBoxTemplateSettings2
  {
    public extern double DropDownOpenedHeight { [MethodImpl] get; }

    public extern double DropDownClosedHeight { [MethodImpl] get; }

    public extern double DropDownOffset { [MethodImpl] get; }

    public extern AnimationDirection SelectedItemDirection { [MethodImpl] get; }

    public extern double DropDownContentMinWidth { [MethodImpl] get; }
  }
}
