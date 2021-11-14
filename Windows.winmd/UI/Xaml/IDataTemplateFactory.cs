// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDataTemplateFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1374526846, 11091, 18267, 156, 136, 12, 24, 50, 200, 53, 26)]
  [ExclusiveTo(typeof (DataTemplate))]
  [WebHostHidden]
  internal interface IDataTemplateFactory
  {
    DataTemplate CreateInstance(object outer, out object inner);
  }
}
