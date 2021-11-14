// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DataRequest))]
  [Guid(1128377915, 64530, 20051, 140, 2, 172, 113, 76, 65, 90, 39)]
  internal interface IDataRequest
  {
    DataPackage Data { get; set; }

    DateTime Deadline { get; }

    void FailWithDisplayText(string value);

    DataRequestDeferral GetDeferral();
  }
}
