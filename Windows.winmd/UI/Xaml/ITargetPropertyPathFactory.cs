// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.ITargetPropertyPathFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ExclusiveTo(typeof (TargetPropertyPath))]
  [Guid(2297351368, 39394, 19012, 153, 7, 180, 75, 200, 110, 43, 190)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITargetPropertyPathFactory
  {
    TargetPropertyPath CreateInstance(DependencyProperty targetProperty);
  }
}
