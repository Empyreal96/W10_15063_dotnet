// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Interop.IBindableVector
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Interop
{
  [Guid(960358366, 28624, 19469, 187, 113, 71, 36, 74, 17, 62, 147)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public interface IBindableVector : IBindableIterable
  {
    object GetAt(uint index);

    uint Size { get; }

    IBindableVectorView GetView();

    bool IndexOf(object value, out uint index);

    void SetAt(uint index, object value);

    void InsertAt(uint index, object value);

    void RemoveAt(uint index);

    void Append(object value);

    void RemoveAtEnd();

    void Clear();
  }
}
