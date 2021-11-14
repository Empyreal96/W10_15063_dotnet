// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.IWindowActivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(396191207, 18008, 19638, 170, 19, 65, 208, 148, 234, 37, 94)]
  [ExclusiveTo(typeof (WindowActivatedEventArgs))]
  internal interface IWindowActivatedEventArgs : ICoreWindowEventArgs
  {
    CoreWindowActivationState WindowActivationState { get; }
  }
}
