// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Printing.IAddPagesEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing;

namespace Windows.UI.Xaml.Printing
{
  [Guid(3806669797, 1388, 17440, 151, 149, 203, 53, 38, 206, 12, 32)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (AddPagesEventArgs))]
  internal interface IAddPagesEventArgs
  {
    PrintTaskOptions PrintTaskOptions { get; }
  }
}
