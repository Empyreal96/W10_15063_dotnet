// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.IXamlBindingHelperStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml.Markup
{
  [WebHostHidden]
  [Guid(4133288817, 51212, 20474, 134, 238, 85, 135, 84, 238, 51, 109)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (XamlBindingHelper))]
  internal interface IXamlBindingHelperStatics
  {
    DependencyProperty DataTemplateComponentProperty { get; }

    IDataTemplateComponent GetDataTemplateComponent(DependencyObject element);

    void SetDataTemplateComponent(DependencyObject element, IDataTemplateComponent value);

    void SuspendRendering(UIElement target);

    void ResumeRendering(UIElement target);

    object ConvertValue(TypeName type, object value);

    void SetPropertyFromString(
      object dependencyObject,
      DependencyProperty propertyToSet,
      string value);

    void SetPropertyFromBoolean(
      object dependencyObject,
      DependencyProperty propertyToSet,
      bool value);

    void SetPropertyFromChar16(
      object dependencyObject,
      DependencyProperty propertyToSet,
      char value);

    void SetPropertyFromDateTime(
      object dependencyObject,
      DependencyProperty propertyToSet,
      DateTime value);

    void SetPropertyFromDouble(
      object dependencyObject,
      DependencyProperty propertyToSet,
      double value);

    void SetPropertyFromInt32(object dependencyObject, DependencyProperty propertyToSet, int value);

    void SetPropertyFromUInt32(
      object dependencyObject,
      DependencyProperty propertyToSet,
      uint value);

    void SetPropertyFromInt64(
      object dependencyObject,
      DependencyProperty propertyToSet,
      long value);

    void SetPropertyFromUInt64(
      object dependencyObject,
      DependencyProperty propertyToSet,
      ulong value);

    void SetPropertyFromSingle(
      object dependencyObject,
      DependencyProperty propertyToSet,
      float value);

    void SetPropertyFromPoint(
      object dependencyObject,
      DependencyProperty propertyToSet,
      Point value);

    void SetPropertyFromRect(object dependencyObject, DependencyProperty propertyToSet, Rect value);

    void SetPropertyFromSize(object dependencyObject, DependencyProperty propertyToSet, Size value);

    void SetPropertyFromTimeSpan(
      object dependencyObject,
      DependencyProperty propertyToSet,
      TimeSpan value);

    void SetPropertyFromByte(object dependencyObject, DependencyProperty propertyToSet, byte value);

    void SetPropertyFromUri(object dependencyObject, DependencyProperty propertyToSet, Uri value);

    void SetPropertyFromObject(
      object dependencyObject,
      DependencyProperty propertyToSet,
      object value);
  }
}
