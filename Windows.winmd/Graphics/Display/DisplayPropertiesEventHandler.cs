// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.DisplayPropertiesEventHandler
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  [Deprecated("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [Guid(3688729345, 61857, 18129, 158, 227, 84, 59, 204, 153, 89, 128)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate void DisplayPropertiesEventHandler(object sender);
}
