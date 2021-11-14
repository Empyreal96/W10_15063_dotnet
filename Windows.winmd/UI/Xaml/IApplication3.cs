// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IApplication3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Application))]
  [Guid(3077942652, 6328, 17866, 161, 176, 220, 72, 62, 75, 16, 40)]
  internal interface IApplication3
  {
    ApplicationHighContrastAdjustment HighContrastAdjustment { get; set; }
  }
}
