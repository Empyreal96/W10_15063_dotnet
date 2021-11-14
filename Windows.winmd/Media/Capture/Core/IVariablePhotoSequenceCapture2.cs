// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Core.IVariablePhotoSequenceCapture2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Core
{
  [ExclusiveTo(typeof (VariablePhotoSequenceCapture))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4264321724, 20656, 17379, 145, 124, 227, 185, 39, 152, 148, 47)]
  internal interface IVariablePhotoSequenceCapture2
  {
    [RemoteAsync]
    IAsyncAction UpdateSettingsAsync();
  }
}
