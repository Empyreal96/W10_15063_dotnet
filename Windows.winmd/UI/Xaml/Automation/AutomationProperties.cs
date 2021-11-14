// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.AutomationProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Windows.UI.Xaml.Automation
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IAutomationPropertiesStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAutomationPropertiesStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IAutomationPropertiesStatics6), 262144, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Static(typeof (IAutomationPropertiesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IAutomationPropertiesStatics4), 131072, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAutomationPropertiesStatics5), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class AutomationProperties : IAutomationProperties
  {
    public static extern DependencyProperty CultureProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern int GetCulture(DependencyObject element);

    [MethodImpl]
    public static extern void SetCulture(DependencyObject element, int value);

    public static extern DependencyProperty IsPeripheralProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool GetIsPeripheral(DependencyObject element);

    [MethodImpl]
    public static extern void SetIsPeripheral(DependencyObject element, bool value);

    public static extern DependencyProperty IsDataValidForFormProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool GetIsDataValidForForm(DependencyObject element);

    [MethodImpl]
    public static extern void SetIsDataValidForForm(DependencyObject element, bool value);

    public static extern DependencyProperty FullDescriptionProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern string GetFullDescription(DependencyObject element);

    [MethodImpl]
    public static extern void SetFullDescription(DependencyObject element, string value);

    public static extern DependencyProperty LocalizedControlTypeProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern string GetLocalizedControlType(DependencyObject element);

    [MethodImpl]
    public static extern void SetLocalizedControlType(DependencyObject element, string value);

    public static extern DependencyProperty DescribedByProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern IVector<DependencyObject> GetDescribedBy(
      DependencyObject element);

    public static extern DependencyProperty FlowsToProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern IVector<DependencyObject> GetFlowsTo(
      DependencyObject element);

    public static extern DependencyProperty FlowsFromProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern IVector<DependencyObject> GetFlowsFrom(
      DependencyObject element);

    public static extern DependencyProperty LandmarkTypeProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern AutomationLandmarkType GetLandmarkType(
      DependencyObject element);

    [MethodImpl]
    public static extern void SetLandmarkType(
      DependencyObject element,
      AutomationLandmarkType value);

    public static extern DependencyProperty LocalizedLandmarkTypeProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern string GetLocalizedLandmarkType(DependencyObject element);

    [MethodImpl]
    public static extern void SetLocalizedLandmarkType(DependencyObject element, string value);

    public static extern DependencyProperty PositionInSetProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern int GetPositionInSet(DependencyObject element);

    [MethodImpl]
    public static extern void SetPositionInSet(DependencyObject element, int value);

    public static extern DependencyProperty SizeOfSetProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern int GetSizeOfSet(DependencyObject element);

    [MethodImpl]
    public static extern void SetSizeOfSet(DependencyObject element, int value);

    public static extern DependencyProperty LevelProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern int GetLevel(DependencyObject element);

    [MethodImpl]
    public static extern void SetLevel(DependencyObject element, int value);

    public static extern DependencyProperty AnnotationsProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern IVector<AutomationAnnotation> GetAnnotations(
      DependencyObject element);

    public static extern DependencyProperty AccessibilityViewProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern AccessibilityView GetAccessibilityView(
      DependencyObject element);

    [MethodImpl]
    public static extern void SetAccessibilityView(
      DependencyObject element,
      AccessibilityView value);

    public static extern DependencyProperty ControlledPeersProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern IVector<UIElement> GetControlledPeers(
      DependencyObject element);

    public static extern DependencyProperty AcceleratorKeyProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern string GetAcceleratorKey(DependencyObject element);

    [MethodImpl]
    public static extern void SetAcceleratorKey(DependencyObject element, string value);

    public static extern DependencyProperty AccessKeyProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern string GetAccessKey(DependencyObject element);

    [MethodImpl]
    public static extern void SetAccessKey(DependencyObject element, string value);

    public static extern DependencyProperty AutomationIdProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern string GetAutomationId(DependencyObject element);

    [MethodImpl]
    public static extern void SetAutomationId(DependencyObject element, string value);

    public static extern DependencyProperty HelpTextProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern string GetHelpText(DependencyObject element);

    [MethodImpl]
    public static extern void SetHelpText(DependencyObject element, string value);

    public static extern DependencyProperty IsRequiredForFormProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool GetIsRequiredForForm(DependencyObject element);

    [MethodImpl]
    public static extern void SetIsRequiredForForm(DependencyObject element, bool value);

    public static extern DependencyProperty ItemStatusProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern string GetItemStatus(DependencyObject element);

    [MethodImpl]
    public static extern void SetItemStatus(DependencyObject element, string value);

    public static extern DependencyProperty ItemTypeProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern string GetItemType(DependencyObject element);

    [MethodImpl]
    public static extern void SetItemType(DependencyObject element, string value);

    public static extern DependencyProperty LabeledByProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern UIElement GetLabeledBy(DependencyObject element);

    [MethodImpl]
    public static extern void SetLabeledBy(DependencyObject element, UIElement value);

    public static extern DependencyProperty NameProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern string GetName(DependencyObject element);

    [MethodImpl]
    public static extern void SetName(DependencyObject element, string value);

    public static extern DependencyProperty LiveSettingProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern AutomationLiveSetting GetLiveSetting(
      DependencyObject element);

    [MethodImpl]
    public static extern void SetLiveSetting(DependencyObject element, AutomationLiveSetting value);
  }
}
