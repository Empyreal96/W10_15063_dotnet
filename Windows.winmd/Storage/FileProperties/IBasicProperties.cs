// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.IBasicProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  [ExclusiveTo(typeof (BasicProperties))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3495777755, 30814, 19046, 190, 2, 155, 238, 197, 138, 234, 129)]
  internal interface IBasicProperties
  {
    ulong Size { get; }

    DateTime DateModified { get; }

    DateTime ItemDate { get; }
  }
}
