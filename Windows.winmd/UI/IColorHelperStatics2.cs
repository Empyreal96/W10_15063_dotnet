// Decompiled with JetBrains decompiler
// Type: Windows.UI.IColorHelperStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (ColorHelper))]
  [Guid(618245890, 28336, 19348, 133, 92, 252, 240, 129, 141, 154, 22)]
  internal interface IColorHelperStatics2
  {
    string ToDisplayName(Color color);
  }
}
