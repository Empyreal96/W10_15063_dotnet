// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ISystemNavigationManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [Guid(2466394392, 53072, 17062, 151, 6, 105, 16, 127, 161, 34, 225)]
  [ExclusiveTo(typeof (SystemNavigationManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISystemNavigationManager
  {
    event EventHandler<BackRequestedEventArgs> BackRequested;
  }
}
