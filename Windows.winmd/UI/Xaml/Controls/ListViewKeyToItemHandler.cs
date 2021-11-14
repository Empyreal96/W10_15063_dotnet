// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ListViewKeyToItemHandler
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(654137429, 46384, 18056, 185, 240, 66, 130, 73, 23, 142, 248)]
  [WebHostHidden]
  public delegate IAsyncOperation<object> ListViewKeyToItemHandler(string key);
}
