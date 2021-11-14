// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDragEventArgs3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (DragEventArgs))]
  [WebHostHidden]
  [Guid(3494888390, 33049, 17018, 129, 82, 95, 149, 80, 204, 4, 22)]
  internal interface IDragEventArgs3
  {
    DataPackageOperation AllowedOperations { get; }
  }
}
