// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentControlFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ContentControl))]
  [Guid(2869000985, 6510, 20181, 162, 127, 85, 197, 143, 177, 103, 63)]
  internal interface IContentControlFactory
  {
    ContentControl CreateInstance(object outer, out object inner);
  }
}
