// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.SplitViewTemplateSettings
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
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class SplitViewTemplateSettings : DependencyObject, ISplitViewTemplateSettings
  {
    public extern double OpenPaneLength { [MethodImpl] get; }

    public extern double NegativeOpenPaneLength { [MethodImpl] get; }

    public extern double OpenPaneLengthMinusCompactLength { [MethodImpl] get; }

    public extern double NegativeOpenPaneLengthMinusCompactLength { [MethodImpl] get; }

    public extern GridLength OpenPaneGridLength { [MethodImpl] get; }

    public extern GridLength CompactPaneGridLength { [MethodImpl] get; }
  }
}
