// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBox4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (TextBox))]
  [Guid(3052512885, 52449, 17839, 174, 249, 196, 120, 123, 187, 94, 48)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  internal interface ITextBox4
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<string>> GetLinguisticAlternativesAsync();
  }
}
