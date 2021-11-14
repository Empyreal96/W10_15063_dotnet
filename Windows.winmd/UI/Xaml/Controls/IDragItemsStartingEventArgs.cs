// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IDragItemsStartingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1909399900, 56045, 18307, 170, 17, 220, 87, 77, 39, 19, 233)]
  [ExclusiveTo(typeof (DragItemsStartingEventArgs))]
  internal interface IDragItemsStartingEventArgs
  {
    bool Cancel { get; set; }

    IVector<object> Items { get; }

    DataPackage Data { get; }
  }
}
