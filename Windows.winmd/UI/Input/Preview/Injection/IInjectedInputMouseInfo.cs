// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.IInjectedInputMouseInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  [Guid(2532666987, 58490, 23796, 65, 141, 138, 95, 185, 103, 12, 125)]
  [ExclusiveTo(typeof (InjectedInputMouseInfo))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IInjectedInputMouseInfo
  {
    InjectedInputMouseOptions MouseOptions { get; set; }

    uint MouseData { get; set; }

    int DeltaY { get; set; }

    int DeltaX { get; set; }

    uint TimeOffsetInMilliseconds { get; set; }
  }
}
