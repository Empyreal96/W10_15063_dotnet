// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataProviderRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DataProviderRequest))]
  [Guid(3954995543, 54216, 18394, 172, 222, 248, 35, 136, 213, 247, 22)]
  internal interface IDataProviderRequest
  {
    string FormatId { get; }

    DateTime Deadline { get; }

    DataProviderDeferral GetDeferral();

    void SetData([HasVariant] object value);
  }
}
