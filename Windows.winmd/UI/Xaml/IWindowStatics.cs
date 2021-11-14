// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IWindowStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (Window))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2469561353, 20129, 19194, 131, 220, 12, 78, 115, 232, 139, 177)]
  internal interface IWindowStatics
  {
    Window Current { get; }
  }
}
