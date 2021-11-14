// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.IFileSavePicker3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers
{
  [ExclusiveTo(typeof (FileSavePicker))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1770712169, 47676, 20049, 189, 144, 74, 188, 187, 244, 207, 175)]
  internal interface IFileSavePicker3 : IFileSavePicker
  {
    string EnterpriseId { get; set; }
  }
}
