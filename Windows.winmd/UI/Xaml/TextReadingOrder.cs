// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.TextReadingOrder
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum TextReadingOrder
  {
    [Deprecated("Consider using UseFlowDirection, which is an improved version of Default. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] Default = 0,
    UseFlowDirection = 0,
    DetectFromContent = 1,
  }
}
