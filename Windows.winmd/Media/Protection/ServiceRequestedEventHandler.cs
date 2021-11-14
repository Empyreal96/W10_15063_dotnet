// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.ServiceRequestedEventHandler
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3537277114, 51913, 18657, 149, 192, 211, 132, 149, 168, 64, 85)]
  public delegate void ServiceRequestedEventHandler(
    MediaProtectionManager sender,
    ServiceRequestedEventArgs e);
}
