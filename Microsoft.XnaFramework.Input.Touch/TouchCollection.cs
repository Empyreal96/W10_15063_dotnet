// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Input.Touch.TouchCollection
// Assembly: Microsoft.Xna.Framework.Input.Touch, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 8E9BEFFA-058F-469C-A733-2CE9128BE180
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI3BB0~1.DLL

using System;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Xna.Framework.Input.Touch
{
  public struct TouchCollection : 
    IList<TouchLocation>,
    ICollection<TouchLocation>,
    IEnumerable<TouchLocation>,
    IEnumerable
  {
    private bool isConnected;
    private int locationCount;
    private TouchLocation location0;
    private TouchLocation location1;
    private TouchLocation location2;
    private TouchLocation location3;
    private TouchLocation location4;
    private TouchLocation location5;
    private TouchLocation location6;
    private TouchLocation location7;
    private static TouchLocation[] prevLocations = new TouchLocation[8];

    public TouchCollection(TouchLocation[] touches)
    {
      if (touches == null)
        throw new ArgumentNullException(nameof (touches));
      if (touches.Length > 8)
        throw new ArgumentOutOfRangeException(nameof (touches));
      this.isConnected = true;
      this.locationCount = 0;
      this.location0 = new TouchLocation();
      this.location1 = new TouchLocation();
      this.location2 = new TouchLocation();
      this.location3 = new TouchLocation();
      this.location4 = new TouchLocation();
      this.location5 = new TouchLocation();
      this.location6 = new TouchLocation();
      this.location7 = new TouchLocation();
      foreach (TouchLocation touch in touches)
      {
        TouchLocation previousLocation;
        if (touch.TryGetPreviousLocation(out previousLocation))
          this.AddTouchLocation(touch.Id, touch.State, touch.Position.X, touch.Position.Y, previousLocation.State, previousLocation.Position.X, previousLocation.Position.Y);
        else
          this.AddTouchLocation(touch.Id, touch.State, touch.Position.X, touch.Position.Y, TouchLocationState.Invalid, 0.0f, 0.0f);
      }
    }

    public bool IsConnected => this.isConnected;

    public bool FindById(int id, out TouchLocation touchLocation)
    {
      for (int index = 0; index < this.Count; ++index)
      {
        if (this[index].Id == id)
        {
          touchLocation = this[index];
          return true;
        }
      }
      touchLocation = new TouchLocation();
      return false;
    }

    private void AddTouchLocation(
      int id,
      TouchLocationState state,
      float x,
      float y,
      TouchLocationState prevState,
      float prevX,
      float prevY)
    {
      switch (this.locationCount++)
      {
        case 0:
          this.location0 = new TouchLocation(id, state, x, y, prevState, prevX, prevY);
          break;
        case 1:
          this.location1 = new TouchLocation(id, state, x, y, prevState, prevX, prevY);
          break;
        case 2:
          this.location2 = new TouchLocation(id, state, x, y, prevState, prevX, prevY);
          break;
        case 3:
          this.location3 = new TouchLocation(id, state, x, y, prevState, prevX, prevY);
          break;
        case 4:
          this.location4 = new TouchLocation(id, state, x, y, prevState, prevX, prevY);
          break;
        case 5:
          this.location5 = new TouchLocation(id, state, x, y, prevState, prevX, prevY);
          break;
        case 6:
          this.location6 = new TouchLocation(id, state, x, y, prevState, prevX, prevY);
          break;
        case 7:
          this.location7 = new TouchLocation(id, state, x, y, prevState, prevX, prevY);
          break;
      }
    }

    private bool GetPreviousLocation(int id, int prevLocationCount, out TouchLocation location)
    {
      for (int index = 0; index < prevLocationCount; ++index)
      {
        if (TouchCollection.prevLocations[index].Id == id)
        {
          location = TouchCollection.prevLocations[index];
          return true;
        }
      }
      location = new TouchLocation(-1, TouchLocationState.Invalid, Vector2.Zero);
      return false;
    }

    internal void Update(
      ref XNAINPUT_TOUCH_LOCATION_STATE prevState,
      ref XNAINPUT_TOUCH_LOCATION_STATE newState,
      bool connected)
    {
      lock (TouchCollection.prevLocations)
      {
        this.isConnected = connected;
        int locationCount = this.locationCount;
        this.locationCount = 0;
        TouchCollection.prevLocations[0] = this.location0;
        TouchCollection.prevLocations[1] = this.location1;
        TouchCollection.prevLocations[2] = this.location2;
        TouchCollection.prevLocations[3] = this.location3;
        TouchCollection.prevLocations[4] = this.location4;
        TouchCollection.prevLocations[5] = this.location5;
        TouchCollection.prevLocations[6] = this.location6;
        TouchCollection.prevLocations[7] = this.location7;
        for (int index = 0; index < prevState.Count; ++index)
        {
          TouchCollection.LocInfo locInfo;
          if (TouchCollection.GetLocInfo(ref prevState, index, out locInfo) && TouchCollection.FindById(ref newState, locInfo.Id) < 0)
          {
            TouchLocation location;
            if (this.GetPreviousLocation(locInfo.Id, locationCount, out location))
              this.AddTouchLocation(locInfo.Id, TouchLocationState.Released, locInfo.X, locInfo.Y, location.State, location.Position.X, location.Position.Y);
            else
              this.AddTouchLocation(locInfo.Id, TouchLocationState.Released, locInfo.X, locInfo.Y, TouchLocationState.Invalid, 0.0f, 0.0f);
          }
        }
        for (int index = 0; index < newState.Count; ++index)
        {
          TouchCollection.LocInfo locInfo1;
          if (TouchCollection.GetLocInfo(ref newState, index, out locInfo1))
          {
            int byId = TouchCollection.FindById(ref prevState, locInfo1.Id);
            if (byId >= 0)
            {
              TouchCollection.LocInfo locInfo2;
              TouchCollection.GetLocInfo(ref prevState, byId, out locInfo2);
              TouchLocationState prevState1 = TouchLocationState.Invalid;
              TouchLocation location;
              if (this.GetPreviousLocation(locInfo1.Id, locationCount, out location))
                prevState1 = location.State;
              this.AddTouchLocation(locInfo1.Id, TouchLocationState.Moved, locInfo1.X, locInfo1.Y, prevState1, locInfo2.X, locInfo2.Y);
            }
            else
              this.AddTouchLocation(locInfo1.Id, TouchLocationState.Pressed, locInfo1.X, locInfo1.Y, TouchLocationState.Invalid, 0.0f, 0.0f);
          }
        }
      }
      prevState = newState;
    }

    private static bool GetLocInfo(
      ref XNAINPUT_TOUCH_LOCATION_STATE state,
      int index,
      out TouchCollection.LocInfo locInfo)
    {
      locInfo.Id = 0;
      locInfo.X = 0.0f;
      locInfo.Y = 0.0f;
      if (index < state.Count)
      {
        switch (index)
        {
          case 0:
            locInfo = new TouchCollection.LocInfo(state.Id0, state.X0, state.Y0);
            return true;
          case 1:
            locInfo = new TouchCollection.LocInfo(state.Id1, state.X1, state.Y1);
            return true;
          case 2:
            locInfo = new TouchCollection.LocInfo(state.Id2, state.X2, state.Y2);
            return true;
          case 3:
            locInfo = new TouchCollection.LocInfo(state.Id3, state.X3, state.Y3);
            return true;
        }
      }
      return false;
    }

    internal static int FindById(ref XNAINPUT_TOUCH_LOCATION_STATE state, int id)
    {
      if (state.Count > 0 && state.Id0 == id)
        return 0;
      if (state.Count > 1 && state.Id1 == id)
        return 1;
      if (state.Count > 2 && state.Id2 == id)
        return 2;
      return state.Count > 3 && state.Id3 == id ? 3 : -1;
    }

    public int IndexOf(TouchLocation item)
    {
      for (int index = 0; index < this.Count; ++index)
      {
        if (this[index] == item)
          return index;
      }
      return -1;
    }

    public void Insert(int index, TouchLocation item) => throw new NotSupportedException();

    public void RemoveAt(int index) => throw new NotSupportedException();

    public TouchLocation this[int index]
    {
      get
      {
        if (index < 0 || index >= this.Count)
          throw new ArgumentOutOfRangeException(nameof (index));
        switch (index)
        {
          case 0:
            return this.location0;
          case 1:
            return this.location1;
          case 2:
            return this.location2;
          case 3:
            return this.location3;
          case 4:
            return this.location4;
          case 5:
            return this.location5;
          case 6:
            return this.location6;
          case 7:
            return this.location7;
          default:
            return this.location7;
        }
      }
      set => throw new NotSupportedException();
    }

    public void Add(TouchLocation item) => throw new NotSupportedException();

    public void Clear() => throw new NotSupportedException();

    public bool Contains(TouchLocation item) => this.IndexOf(item) >= 0;

    public void CopyTo(TouchLocation[] array, int arrayIndex)
    {
      if (array == null)
        throw new ArgumentNullException(nameof (array));
      if (arrayIndex < 0)
        throw new ArgumentOutOfRangeException(nameof (arrayIndex));
      long num = (long) arrayIndex + (long) this.Count;
      if ((long) array.Length < num)
        throw new ArgumentOutOfRangeException(nameof (arrayIndex));
      for (int index = 0; index < this.Count; ++index)
        array[arrayIndex + index] = this[index];
    }

    public int Count => this.locationCount;

    public bool IsReadOnly => true;

    public bool Remove(TouchLocation item) => throw new NotSupportedException();

    public TouchCollection.Enumerator GetEnumerator() => new TouchCollection.Enumerator(this);

    IEnumerator<TouchLocation> IEnumerable<TouchLocation>.GetEnumerator() => (IEnumerator<TouchLocation>) new TouchCollection.Enumerator(this);

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) new TouchCollection.Enumerator(this);

    private struct LocInfo
    {
      public int Id;
      public float X;
      public float Y;

      public LocInfo(int id, float x, float y)
      {
        this.Id = id;
        this.X = x;
        this.Y = y;
      }
    }

    public struct Enumerator : IEnumerator<TouchLocation>, IEnumerator, IDisposable
    {
      private TouchCollection collection;
      private int position;

      internal Enumerator(TouchCollection collection)
      {
        this.collection = collection;
        this.position = -1;
      }

      public TouchLocation Current => this.collection[this.position];

      public bool MoveNext()
      {
        ++this.position;
        if (this.position < this.collection.Count)
          return true;
        this.position = this.collection.Count;
        return false;
      }

      void IEnumerator.Reset() => this.position = -1;

      public void Dispose()
      {
      }

      object IEnumerator.Current => (object) this.Current;
    }
  }
}
