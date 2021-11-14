// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IPropertyMetadata
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(2169434893, 36120, 17546, 134, 68, 242, 203, 81, 231, 3, 128)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PropertyMetadata))]
  [WebHostHidden]
  internal interface IPropertyMetadata
  {
    object DefaultValue { get; }

    CreateDefaultValueCallback CreateDefaultValueCallback { get; }
  }
}
