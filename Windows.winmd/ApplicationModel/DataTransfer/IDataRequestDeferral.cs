// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataRequestDeferral
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1841608863, 902, 16995, 135, 193, 237, 125, 206, 48, 137, 14)]
  [ExclusiveTo(typeof (DataRequestDeferral))]
  internal interface IDataRequestDeferral
  {
    void Complete();
  }
}
