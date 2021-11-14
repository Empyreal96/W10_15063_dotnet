// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.PropertyMetadata
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IPropertyMetadataStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IPropertyMetadataFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class PropertyMetadata : IPropertyMetadata
  {
    [MethodImpl]
    public extern PropertyMetadata(object defaultValue);

    [MethodImpl]
    public extern PropertyMetadata(
      object defaultValue,
      PropertyChangedCallback propertyChangedCallback);

    public extern object DefaultValue { [MethodImpl] get; }

    public extern CreateDefaultValueCallback CreateDefaultValueCallback { [MethodImpl] get; }

    [Overload("CreateWithDefaultValue")]
    [DefaultOverload]
    [MethodImpl]
    public static extern PropertyMetadata Create(object defaultValue);

    [Overload("CreateWithDefaultValueAndCallback")]
    [DefaultOverload]
    [MethodImpl]
    public static extern PropertyMetadata Create(
      object defaultValue,
      PropertyChangedCallback propertyChangedCallback);

    [Overload("CreateWithFactory")]
    [MethodImpl]
    public static extern PropertyMetadata Create(
      CreateDefaultValueCallback createDefaultValueCallback);

    [Overload("CreateWithFactoryAndCallback")]
    [MethodImpl]
    public static extern PropertyMetadata Create(
      CreateDefaultValueCallback createDefaultValueCallback,
      PropertyChangedCallback propertyChangedCallback);
  }
}
