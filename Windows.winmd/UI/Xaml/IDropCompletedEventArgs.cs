// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDropCompletedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ExclusiveTo(typeof (DropCompletedEventArgs))]
  [Guid(1817166216, 38332, 16993, 158, 197, 33, 202, 182, 119, 183, 52)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDropCompletedEventArgs
  {
    DataPackageOperation DropResult { get; }
  }
}
