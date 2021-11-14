// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardProvisioning2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [ExclusiveTo(typeof (SmartCardProvisioning))]
  [Guid(285026539, 16249, 19302, 155, 124, 17, 193, 73, 183, 208, 188)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISmartCardProvisioning2
  {
    [RemoteAsync]
    IAsyncOperation<string> GetAuthorityKeyContainerNameAsync();
  }
}
