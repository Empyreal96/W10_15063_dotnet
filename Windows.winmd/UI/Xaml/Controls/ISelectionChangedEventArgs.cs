// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISelectionChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SelectionChangedEventArgs))]
  [Guid(3379745500, 46601, 18264, 133, 30, 167, 153, 194, 29, 233, 125)]
  [WebHostHidden]
  internal interface ISelectionChangedEventArgs
  {
    IVector<object> AddedItems { get; }

    IVector<object> RemovedItems { get; }
  }
}
