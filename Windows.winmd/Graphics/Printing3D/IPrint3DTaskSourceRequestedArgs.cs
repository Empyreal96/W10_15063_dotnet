// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrint3DTaskSourceRequestedArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [ExclusiveTo(typeof (Print3DTaskSourceRequestedArgs))]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [Guid(3346832058, 9391, 16973, 163, 191, 146, 37, 12, 53, 86, 2)]
  internal interface IPrint3DTaskSourceRequestedArgs
  {
    void SetSource(Printing3D3MFPackage source);
  }
}
