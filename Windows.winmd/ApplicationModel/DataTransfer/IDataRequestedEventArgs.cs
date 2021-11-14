// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [Guid(3414927367, 27333, 17353, 138, 197, 155, 162, 50, 22, 49, 130)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DataRequestedEventArgs))]
  internal interface IDataRequestedEventArgs
  {
    DataRequest Request { get; }
  }
}
