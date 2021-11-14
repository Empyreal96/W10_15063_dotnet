// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ISystemNavigationManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [ExclusiveTo(typeof (SystemNavigationManager))]
  [Guid(3696408014, 48864, 17157, 140, 84, 104, 34, 142, 214, 131, 181)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISystemNavigationManagerStatics
  {
    SystemNavigationManager GetForCurrentView();
  }
}
