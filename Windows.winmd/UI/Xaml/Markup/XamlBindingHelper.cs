// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.XamlBindingHelper
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml.Markup
{
  [Static(typeof (IXamlBindingHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class XamlBindingHelper : IXamlBindingHelper
  {
    public static extern DependencyProperty DataTemplateComponentProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern IDataTemplateComponent GetDataTemplateComponent(
      DependencyObject element);

    [MethodImpl]
    public static extern void SetDataTemplateComponent(
      DependencyObject element,
      IDataTemplateComponent value);

    [MethodImpl]
    public static extern void SuspendRendering(UIElement target);

    [MethodImpl]
    public static extern void ResumeRendering(UIElement target);

    [MethodImpl]
    public static extern object ConvertValue(TypeName type, object value);

    [MethodImpl]
    public static extern void SetPropertyFromString(
      object dependencyObject,
      DependencyProperty propertyToSet,
      string value);

    [MethodImpl]
    public static extern void SetPropertyFromBoolean(
      object dependencyObject,
      DependencyProperty propertyToSet,
      bool value);

    [MethodImpl]
    public static extern void SetPropertyFromChar16(
      object dependencyObject,
      DependencyProperty propertyToSet,
      char value);

    [MethodImpl]
    public static extern void SetPropertyFromDateTime(
      object dependencyObject,
      DependencyProperty propertyToSet,
      DateTime value);

    [MethodImpl]
    public static extern void SetPropertyFromDouble(
      object dependencyObject,
      DependencyProperty propertyToSet,
      double value);

    [MethodImpl]
    public static extern void SetPropertyFromInt32(
      object dependencyObject,
      DependencyProperty propertyToSet,
      int value);

    [MethodImpl]
    public static extern void SetPropertyFromUInt32(
      object dependencyObject,
      DependencyProperty propertyToSet,
      uint value);

    [MethodImpl]
    public static extern void SetPropertyFromInt64(
      object dependencyObject,
      DependencyProperty propertyToSet,
      long value);

    [MethodImpl]
    public static extern void SetPropertyFromUInt64(
      object dependencyObject,
      DependencyProperty propertyToSet,
      ulong value);

    [MethodImpl]
    public static extern void SetPropertyFromSingle(
      object dependencyObject,
      DependencyProperty propertyToSet,
      float value);

    [MethodImpl]
    public static extern void SetPropertyFromPoint(
      object dependencyObject,
      DependencyProperty propertyToSet,
      Point value);

    [MethodImpl]
    public static extern void SetPropertyFromRect(
      object dependencyObject,
      DependencyProperty propertyToSet,
      Rect value);

    [MethodImpl]
    public static extern void SetPropertyFromSize(
      object dependencyObject,
      DependencyProperty propertyToSet,
      Size value);

    [MethodImpl]
    public static extern void SetPropertyFromTimeSpan(
      object dependencyObject,
      DependencyProperty propertyToSet,
      TimeSpan value);

    [MethodImpl]
    public static extern void SetPropertyFromByte(
      object dependencyObject,
      DependencyProperty propertyToSet,
      byte value);

    [MethodImpl]
    public static extern void SetPropertyFromUri(
      object dependencyObject,
      DependencyProperty propertyToSet,
      Uri value);

    [MethodImpl]
    public static extern void SetPropertyFromObject(
      object dependencyObject,
      DependencyProperty propertyToSet,
      object value);
  }
}
