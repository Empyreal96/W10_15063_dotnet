// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrint3DTaskRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [ExclusiveTo(typeof (Print3DTaskRequest))]
  [Guid(630572143, 8773, 19546, 135, 49, 13, 96, 77, 198, 188, 60)]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  internal interface IPrint3DTaskRequest
  {
    Print3DTask CreateTask(
      string title,
      string printerId,
      Print3DTaskSourceRequestedHandler handler);
  }
}
