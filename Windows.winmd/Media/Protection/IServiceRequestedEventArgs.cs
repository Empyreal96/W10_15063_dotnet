// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.IServiceRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  [ExclusiveTo(typeof (ServiceRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(875051951, 43956, 20417, 189, 137, 147, 241, 6, 87, 58, 73)]
  internal interface IServiceRequestedEventArgs
  {
    IMediaProtectionServiceRequest Request { get; }

    MediaProtectionServiceCompletion Completion { get; }
  }
}
