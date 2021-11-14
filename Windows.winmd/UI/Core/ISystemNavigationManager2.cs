// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ISystemNavigationManager2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [ExclusiveTo(typeof (SystemNavigationManager))]
  [Guid(2354119681, 26558, 18862, 149, 9, 103, 28, 30, 84, 163, 137)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISystemNavigationManager2
  {
    AppViewBackButtonVisibility AppViewBackButtonVisibility { get; set; }
  }
}
