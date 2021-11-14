// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.IBinding
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [Guid(1064963179, 53263, 18224, 140, 29, 72, 225, 108, 70, 249, 202)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Binding))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBinding
  {
    PropertyPath Path { get; set; }

    BindingMode Mode { get; set; }

    object Source { get; set; }

    RelativeSource RelativeSource { get; set; }

    string ElementName { get; set; }

    IValueConverter Converter { get; set; }

    object ConverterParameter { get; set; }

    string ConverterLanguage { get; set; }
  }
}
