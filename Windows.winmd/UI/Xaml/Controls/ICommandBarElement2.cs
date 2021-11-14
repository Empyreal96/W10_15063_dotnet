// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICommandBarElement2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(2847871542, 17410, 18056, 185, 135, 157, 43, 155, 123, 242, 189)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public interface ICommandBarElement2
  {
    bool IsInOverflow { get; }

    int DynamicOverflowOrder { get; set; }
  }
}
