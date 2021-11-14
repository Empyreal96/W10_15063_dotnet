// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Hub
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Controls
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IHubStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ContentProperty(Name = "Sections")]
  [Composable(typeof (IHubFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class Hub : Control, IHub, ISemanticZoomInformation
  {
    [MethodImpl]
    public extern Hub();

    public extern object Header { [MethodImpl] get; [MethodImpl] set; }

    public extern DataTemplate HeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    public extern Orientation Orientation { [MethodImpl] get; [MethodImpl] set; }

    public extern int DefaultSectionIndex { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<HubSection> Sections { [MethodImpl] get; }

    public extern IVector<HubSection> SectionsInView { [MethodImpl] get; }

    public extern IObservableVector<object> SectionHeaders { [MethodImpl] get; }

    public extern event HubSectionHeaderClickEventHandler SectionHeaderClick;

    public extern event SectionsInViewChangedEventHandler SectionsInViewChanged;

    [MethodImpl]
    public extern void ScrollToSection(HubSection section);

    public extern SemanticZoom SemanticZoomOwner { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsActiveView { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsZoomedInView { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void InitializeViewChange();

    [MethodImpl]
    public extern void CompleteViewChange();

    [MethodImpl]
    public extern void MakeVisible(SemanticZoomLocation item);

    [MethodImpl]
    public extern void StartViewChangeFrom(
      SemanticZoomLocation source,
      SemanticZoomLocation destination);

    [MethodImpl]
    public extern void StartViewChangeTo(
      SemanticZoomLocation source,
      SemanticZoomLocation destination);

    [MethodImpl]
    public extern void CompleteViewChangeFrom(
      SemanticZoomLocation source,
      SemanticZoomLocation destination);

    [MethodImpl]
    public extern void CompleteViewChangeTo(
      SemanticZoomLocation source,
      SemanticZoomLocation destination);

    public static extern DependencyProperty HeaderProperty { [MethodImpl] get; }

    public static extern DependencyProperty HeaderTemplateProperty { [MethodImpl] get; }

    public static extern DependencyProperty OrientationProperty { [MethodImpl] get; }

    public static extern DependencyProperty DefaultSectionIndexProperty { [MethodImpl] get; }

    public static extern DependencyProperty SemanticZoomOwnerProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsActiveViewProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsZoomedInViewProperty { [MethodImpl] get; }
  }
}
