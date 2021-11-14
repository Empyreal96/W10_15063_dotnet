// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.ScrollPatternIdentifiers
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IScrollPatternIdentifiersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ScrollPatternIdentifiers : IScrollPatternIdentifiers
  {
    public static extern AutomationProperty HorizontallyScrollableProperty { [MethodImpl] get; }

    public static extern AutomationProperty HorizontalScrollPercentProperty { [MethodImpl] get; }

    public static extern AutomationProperty HorizontalViewSizeProperty { [MethodImpl] get; }

    public static extern double NoScroll { [MethodImpl] get; }

    public static extern AutomationProperty VerticallyScrollableProperty { [MethodImpl] get; }

    public static extern AutomationProperty VerticalScrollPercentProperty { [MethodImpl] get; }

    public static extern AutomationProperty VerticalViewSizeProperty { [MethodImpl] get; }
  }
}
