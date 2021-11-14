// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Interop.INotifyCollectionChanged
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Interop
{
  [Guid(682715093, 6705, 18011, 155, 37, 213, 195, 174, 104, 108, 64)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface INotifyCollectionChanged
  {
    event NotifyCollectionChangedEventHandler CollectionChanged;
  }
}
