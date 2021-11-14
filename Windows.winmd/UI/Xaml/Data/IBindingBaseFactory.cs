// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.IBindingBaseFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [Guid(584776762, 30465, 18022, 161, 186, 152, 89, 189, 207, 236, 52)]
  [ExclusiveTo(typeof (BindingBase))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBindingBaseFactory
  {
    BindingBase CreateInstance(object outer, out object inner);
  }
}
