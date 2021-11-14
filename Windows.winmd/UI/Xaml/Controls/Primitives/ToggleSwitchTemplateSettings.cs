// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ToggleSwitchTemplateSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ToggleSwitchTemplateSettings : DependencyObject, IToggleSwitchTemplateSettings
  {
    public extern double KnobCurrentToOnOffset { [MethodImpl] get; }

    public extern double KnobCurrentToOffOffset { [MethodImpl] get; }

    public extern double KnobOnToOffOffset { [MethodImpl] get; }

    public extern double KnobOffToOnOffset { [MethodImpl] get; }

    public extern double CurtainCurrentToOnOffset { [MethodImpl] get; }

    public extern double CurtainCurrentToOffOffset { [MethodImpl] get; }

    public extern double CurtainOnToOffOffset { [MethodImpl] get; }

    public extern double CurtainOffToOnOffset { [MethodImpl] get; }
  }
}
