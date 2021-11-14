// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintTaskRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3501193508, 41755, 17740, 167, 182, 93, 12, 197, 34, 252, 22)]
  [ExclusiveTo(typeof (PrintTaskRequestedEventArgs))]
  internal interface IPrintTaskRequestedEventArgs
  {
    PrintTaskRequest Request { get; }
  }
}
