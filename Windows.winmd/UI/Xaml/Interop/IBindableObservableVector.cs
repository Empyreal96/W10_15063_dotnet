// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Interop.IBindableObservableVector
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Interop
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(4263425334, 32383, 20368, 172, 154, 71, 73, 132, 170, 229, 18)]
  public interface IBindableObservableVector : IBindableVector, IBindableIterable
  {
    event BindableVectorChangedEventHandler VectorChanged;
  }
}
