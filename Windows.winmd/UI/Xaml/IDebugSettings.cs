// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDebugSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (DebugSettings))]
  [Guid(1027940248, 50855, 19735, 131, 152, 216, 58, 6, 113, 131, 216)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IDebugSettings
  {
    bool EnableFrameRateCounter { get; set; }

    bool IsBindingTracingEnabled { get; set; }

    bool IsOverdrawHeatMapEnabled { get; set; }

    event BindingFailedEventHandler BindingFailed;
  }
}
