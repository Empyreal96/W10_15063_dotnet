// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataProviderDeferral
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [ExclusiveTo(typeof (DataProviderDeferral))]
  [Guid(3268354931, 11558, 17369, 182, 157, 220, 184, 109, 3, 246, 218)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDataProviderDeferral
  {
    void Complete();
  }
}
