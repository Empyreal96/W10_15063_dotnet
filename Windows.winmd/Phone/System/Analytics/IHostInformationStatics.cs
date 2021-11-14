// Decompiled with JetBrains decompiler
// Type: Windows.Phone.System.Analytics.IHostInformationStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.System.Analytics
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Guid(1717313616, 7263, 4577, 189, 219, 8, 0, 32, 12, 154, 102)]
  [ExclusiveTo(typeof (HostInformation))]
  internal interface IHostInformationStatics
  {
    string PublisherHostId { get; }
  }
}
