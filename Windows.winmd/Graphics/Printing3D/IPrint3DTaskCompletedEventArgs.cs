// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrint3DTaskCompletedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [ExclusiveTo(typeof (Print3DTaskCompletedEventArgs))]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [Guid(3424195759, 9748, 20253, 172, 204, 214, 252, 79, 218, 84, 85)]
  internal interface IPrint3DTaskCompletedEventArgs
  {
    Print3DTaskCompletion Completion { get; }

    Print3DTaskDetail ExtendedStatus { get; }
  }
}
