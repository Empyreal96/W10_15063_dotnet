// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrint3DTaskRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [ExclusiveTo(typeof (Print3DTaskRequestedEventArgs))]
  [Guid(353154943, 6341, 16599, 159, 64, 250, 179, 9, 110, 5, 169)]
  internal interface IPrint3DTaskRequestedEventArgs
  {
    Print3DTaskRequest Request { get; }
  }
}
