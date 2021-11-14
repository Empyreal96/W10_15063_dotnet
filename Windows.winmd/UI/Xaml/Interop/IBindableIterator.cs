// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Interop.IBindableIterator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Interop
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1780313095, 1901, 18930, 131, 20, 245, 44, 156, 154, 131, 49)]
  public interface IBindableIterator
  {
    object Current { get; }

    bool HasCurrent { get; }

    bool MoveNext();
  }
}
