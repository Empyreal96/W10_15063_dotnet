// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.IBindingFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [ExclusiveTo(typeof (Binding))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(4282563336, 50078, 20350, 132, 52, 161, 86, 144, 131, 136, 60)]
  internal interface IBindingFactory
  {
    Binding CreateInstance(object outer, out object inner);
  }
}
