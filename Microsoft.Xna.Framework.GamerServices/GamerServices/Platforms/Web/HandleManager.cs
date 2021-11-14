// Decompiled with JetBrains decompiler
// Type: GamerServices.Platforms.Web.HandleManager
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using System.Collections.Generic;

namespace GamerServices.Platforms.Web
{
  internal class HandleManager
  {
    private Dictionary<HandleType, HandleManager.HandleGroup> groups = new Dictionary<HandleType, HandleManager.HandleGroup>(3);
    public const int InvalidHandle = 0;
    private const int EntryBits = 24;
    private const int MaxEntryCount = 16777216;
    private const int EntryMask = 16777215;

    public HandleManager()
    {
      for (int index = 0; index < 3; ++index)
        this.groups.Add((HandleType) index, new HandleManager.HandleGroup());
    }

    public int AddEntry(HandleType handleType, object value)
    {
      int num = 0;
      HandleManager.HandleGroup handleGroup;
      if (this.groups.TryGetValue(handleType, out handleGroup))
        num = HandleManager.EncodeHandle(handleType, handleGroup.Add(value));
      return num;
    }

    public void RemoveEntry(int handle)
    {
      HandleType handleType = HandleManager.GetHandleType(handle);
      int entryKey = HandleManager.GetEntryKey(handle);
      HandleManager.HandleGroup handleGroup;
      if (!this.groups.TryGetValue(handleType, out handleGroup))
        return;
      handleGroup.Remove(entryKey);
    }

    public object GetValue(int handle)
    {
      HandleType handleType = HandleManager.GetHandleType(handle);
      int entryKey = HandleManager.GetEntryKey(handle);
      object obj = (object) null;
      HandleManager.HandleGroup handleGroup;
      if (this.groups.TryGetValue(handleType, out handleGroup))
        handleGroup.TryGetValue(entryKey, out obj);
      return obj;
    }

    private static int EncodeHandle(HandleType handleType, int handle) => (int) (handleType + 1) << 24 | handle;

    private static HandleType GetHandleType(int handle) => (HandleType) ((handle >> 24) - 1);

    private static int GetEntryKey(int handle) => handle & 16777215;

    private class HandleGroup
    {
      private Dictionary<int, object> entries = new Dictionary<int, object>();
      private int entryCount;

      public bool TryGetValue(int key, out object value) => this.entries.TryGetValue(key, out value);

      public int Add(object value)
      {
        if (++this.entryCount >= 16777216)
          this.entryCount = 1;
        this.entries.Add(this.entryCount, value);
        return this.entryCount;
      }

      public void Remove(int key) => this.entries.Remove(key);
    }
  }
}
