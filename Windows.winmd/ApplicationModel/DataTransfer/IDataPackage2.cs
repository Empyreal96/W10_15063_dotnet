// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataPackage2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [ExclusiveTo(typeof (DataPackage))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(68952041, 9225, 17889, 165, 56, 76, 83, 238, 238, 4, 167)]
  internal interface IDataPackage2
  {
    void SetApplicationLink(Uri value);

    void SetWebLink(Uri value);
  }
}
