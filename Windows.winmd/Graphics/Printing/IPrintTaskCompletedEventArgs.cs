// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintTaskCompletedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PrintTaskCompletedEventArgs))]
  [Guid(1540175023, 9449, 19472, 141, 7, 20, 195, 70, 186, 63, 206)]
  internal interface IPrintTaskCompletedEventArgs
  {
    PrintTaskCompletion Completion { get; }
  }
}
