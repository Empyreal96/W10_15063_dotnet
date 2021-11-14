// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.IMediaProtectionManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  [Guid(1164527943, 51009, 17227, 167, 158, 71, 76, 18, 217, 61, 47)]
  [ExclusiveTo(typeof (MediaProtectionManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaProtectionManager
  {
    event ServiceRequestedEventHandler ServiceRequested;

    event RebootNeededEventHandler RebootNeeded;

    event ComponentLoadFailedEventHandler ComponentLoadFailed;

    IPropertySet Properties { get; }
  }
}
