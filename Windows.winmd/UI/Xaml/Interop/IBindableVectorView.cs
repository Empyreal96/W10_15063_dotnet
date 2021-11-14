// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Interop.IBindableVectorView
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Interop
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(879613671, 38766, 19395, 129, 93, 236, 226, 67, 188, 15, 51)]
  [WebHostHidden]
  public interface IBindableVectorView : IBindableIterable
  {
    object GetAt(uint index);

    uint Size { get; }

    bool IndexOf(object value, out uint index);
  }
}
