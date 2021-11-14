// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.UserData.CEVT_TYPE
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

namespace Microsoft.Phone.UserData
{
  internal enum CEVT_TYPE
  {
    CEVT_UNSPECIFIED = 0,
    CEVT_I2 = 2,
    CEVT_I4 = 3,
    CEVT_R8 = 5,
    CEVT_BOOL = 11, // 0x0000000B
    CEVT_UI2 = 18, // 0x00000012
    CEVT_UI4 = 19, // 0x00000013
    CEVT_LPWSTR = 31, // 0x0000001F
    CEVT_FILETIME = 64, // 0x00000040
    CEVT_BLOB = 65, // 0x00000041
    CEVT_STREAM = 100, // 0x00000064
    CEVT_RECID = 101, // 0x00000065
    CEVT_AUTO_I4 = 102, // 0x00000066
    CEVT_AUTO_I8 = 103, // 0x00000067
  }
}
