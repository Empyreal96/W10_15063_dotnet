// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.ICollectionViewGroup
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [Guid(2114042328, 55221, 18614, 179, 28, 91, 181, 189, 245, 240, 155)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public interface ICollectionViewGroup
  {
    object Group { get; }

    IObservableVector<object> GroupItems { get; }
  }
}
