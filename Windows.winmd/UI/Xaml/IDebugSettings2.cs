// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDebugSettings2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (DebugSettings))]
  [Guid(1221817733, 57766, 18075, 131, 200, 48, 130, 80, 55, 17, 158)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDebugSettings2
  {
    bool EnableRedrawRegions { get; set; }
  }
}
