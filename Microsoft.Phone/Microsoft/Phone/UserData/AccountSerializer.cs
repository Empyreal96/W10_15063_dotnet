// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.UserData.AccountSerializer
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.UserData
{
  [SecurityCritical]
  internal class AccountSerializer : IElementSerializer<Account>
  {
    [SecurityCritical]
    public Account GetObject(object handle)
    {
      Account account = new Account();
      ACCOUNT structure1 = (ACCOUNT) Marshal.PtrToStructure((IntPtr) handle, typeof (ACCOUNT));
      account.Kind = structure1.fIsDefaultStore == 0U ? StorageKind.Other : StorageKind.Phone;
      IntPtr ptr = structure1.rgPropVals;
      for (int index = 0; (long) index < (long) structure1.cProps; ++index)
      {
        CEPROPVAL structure2 = (CEPROPVAL) Marshal.PtrToStructure(ptr, typeof (CEPROPVAL));
        ptr = (IntPtr) (ptr.ToInt32() + Marshal.SizeOf((object) structure2));
        switch ((PIMPR_PROPS) structure2.propid)
        {
          case PIMPR_PROPS.PIMPR_NETWORK_SOURCE_ID:
            switch ((NETWORK_SOURCE_ID) structure2.val.ulVal)
            {
              case NETWORK_SOURCE_ID.WindowsLive:
                account.Kind = StorageKind.WindowsLive;
                continue;
              case NETWORK_SOURCE_ID.Facebook:
                account.Kind = StorageKind.Facebook;
                continue;
              case NETWORK_SOURCE_ID.Outlook:
                account.Kind = StorageKind.Outlook;
                continue;
              default:
                continue;
            }
          case PIMPR_PROPS.PIMPR_NAME:
            account.Name = Marshal.PtrToStringUni(structure2.val.lpwstr);
            break;
        }
      }
      return account;
    }
  }
}
