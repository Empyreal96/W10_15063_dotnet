// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.IWindowSizeChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [Guid(1512050375, 1062, 18396, 184, 108, 111, 71, 89, 21, 228, 81)]
  [WebHostHidden]
  [ExclusiveTo(typeof (WindowSizeChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWindowSizeChangedEventArgs : ICoreWindowEventArgs
  {
    Size Size { get; }
  }
}
