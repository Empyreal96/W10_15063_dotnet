// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataTransferManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [Guid(2849636778, 57358, 19710, 170, 68, 45, 217, 50, 220, 163, 216)]
  [ExclusiveTo(typeof (DataTransferManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDataTransferManagerStatics
  {
    void ShowShareUI();

    DataTransferManager GetForCurrentView();
  }
}
