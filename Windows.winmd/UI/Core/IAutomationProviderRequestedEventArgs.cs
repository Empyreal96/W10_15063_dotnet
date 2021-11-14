// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.IAutomationProviderRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [ExclusiveTo(typeof (AutomationProviderRequestedEventArgs))]
  [Guid(2518676056, 8639, 19266, 162, 152, 250, 71, 157, 76, 82, 226)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IAutomationProviderRequestedEventArgs : ICoreWindowEventArgs
  {
    object AutomationProvider { get; set; }
  }
}
