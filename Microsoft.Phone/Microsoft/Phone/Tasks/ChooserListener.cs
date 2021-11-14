// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Tasks.ChooserListener
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;
using System.IO;
using System.Runtime.Serialization;

namespace Microsoft.Phone.Tasks
{
  internal static class ChooserListener
  {
    private static object _lock = new object();
    private static bool _isInitialized = false;
    private const string ChooserIdGuid = "6babeb6c-a969-416f-b454-2c3ac723efb2";
    private const string ChooserDataGuid = "5F824C26-5A49-4e91-B958-06B994455A49";
    private static IChooser _warmChooser = (IChooser) null;
    private static ChooserInfo _pendingChooserInfo = (ChooserInfo) null;
    private static bool _fPendingChooserDeserialized = false;
    private static ChildTaskReturnedEventArgs _pendingChooserArgs = (ChildTaskReturnedEventArgs) null;
    private static byte[] _pendingChooserState = (byte[]) null;

    public static void Initialize()
    {
      lock (ChooserListener._lock)
      {
        if (ChooserListener._isInitialized)
          return;
        Task rootTask = ApplicationHost.Current.RootTask;
        if (rootTask == null)
          return;
        rootTask.OnChildTaskReturned = new ITask.ChildTaskReturned(ChooserListener.OnChildTaskReturned);
        ChooserListener._isInitialized = true;
      }
    }

    static ChooserListener() => ChooserListener.Initialize();

    internal static void RegisterChooser(IChooser chooser)
    {
      ChooserListener._warmChooser = ChooserListener._warmChooser == null ? chooser : throw new InvalidOperationException("Not allowed to call Show() multiple times before an invocation returns");
      ChooserListener._pendingChooserInfo = (ChooserInfo) null;
      ChooserListener._pendingChooserState = (byte[]) null;
      ChooserListener._pendingChooserArgs = (ChildTaskReturnedEventArgs) null;
      ChooserListener._fPendingChooserDeserialized = false;
    }

    internal static void DeregisterChooser() => ChooserListener._warmChooser = (IChooser) null;

    internal static void PersistLaunchingChooserInfo(IChooser chooser)
    {
      Task rootTask = ApplicationHost.Current.RootTask;
      if (rootTask == null)
        return;
      rootTask.State["6babeb6c-a969-416f-b454-2c3ac723efb2"] = chooser.GetCorrelationBlob();
      MemoryStream memoryStream = new MemoryStream();
      chooser.Serialize((Stream) memoryStream);
      if (memoryStream.Length <= 0L)
        return;
      byte[] buffer = new byte[memoryStream.Length];
      memoryStream.Seek(0L, SeekOrigin.Begin);
      memoryStream.Read(buffer, 0, buffer.Length);
      rootTask.State["5F824C26-5A49-4e91-B958-06B994455A49"] = buffer;
    }

    internal static bool IsChooserPending => ChooserListener._warmChooser != null;

    internal static void FireChooserComplete(
      ChildTaskReturnedEventArgs chooserArgs,
      IChooser chooser)
    {
      chooser.OnInvokeReturned(chooserArgs.returnBuffer, (Delegate) null);
    }

    internal static bool IsChooserCompletePending(
      IChooser chooser,
      Delegate handler,
      out ChildTaskReturnedEventArgs args)
    {
      bool flag = false;
      args = (ChildTaskReturnedEventArgs) null;
      if (ChooserListener._pendingChooserInfo != null && string.Equals(ChooserInfo.ChooserTypeFromChooser(chooser), ChooserListener._pendingChooserInfo.ChooserType) && ChooserListener._pendingChooserInfo.Observers != null)
      {
        string key = ChooserInfo.ObserverFromDelegate(handler);
        if (ChooserListener._pendingChooserInfo.Observers.ContainsKey(key))
        {
          if (!ChooserListener._fPendingChooserDeserialized)
          {
            if (ChooserListener._pendingChooserState != null)
              chooser.Deserialize((Stream) new MemoryStream(ChooserListener._pendingChooserState));
            ChooserListener._fPendingChooserDeserialized = true;
          }
          ChooserListener._pendingChooserInfo.Observers.Remove(key);
          args = ChooserListener._pendingChooserArgs;
          flag = true;
        }
      }
      return flag;
    }

    private static void OnChildTaskReturned(ChildTaskReturnedEventArgs args)
    {
      if (ChooserListener._warmChooser != null)
      {
        ChooserListener.FireChooserComplete(args, ChooserListener._warmChooser);
      }
      else
      {
        Task rootTask = ApplicationHost.Current.RootTask;
        if (rootTask != null && rootTask.State.ContainsKey("6babeb6c-a969-416f-b454-2c3ac723efb2"))
        {
          byte[] buffer = rootTask.State["6babeb6c-a969-416f-b454-2c3ac723efb2"];
          rootTask.State.Remove("6babeb6c-a969-416f-b454-2c3ac723efb2");
          ChooserListener._pendingChooserInfo = (ChooserInfo) new DataContractSerializer(typeof (ChooserInfo)).ReadObject((Stream) new MemoryStream(buffer));
          if (rootTask.State.ContainsKey("5F824C26-5A49-4e91-B958-06B994455A49"))
          {
            ChooserListener._pendingChooserState = rootTask.State["5F824C26-5A49-4e91-B958-06B994455A49"];
            rootTask.State.Remove("5F824C26-5A49-4e91-B958-06B994455A49");
          }
        }
        ChooserListener._pendingChooserArgs = args;
      }
    }
  }
}
