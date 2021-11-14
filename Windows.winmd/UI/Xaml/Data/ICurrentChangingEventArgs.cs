// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.ICurrentChangingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [Guid(4186512937, 20940, 18397, 165, 185, 53, 220, 73, 20, 175, 105)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CurrentChangingEventArgs))]
  internal interface ICurrentChangingEventArgs
  {
    bool Cancel { get; set; }

    bool IsCancelable { get; }
  }
}
