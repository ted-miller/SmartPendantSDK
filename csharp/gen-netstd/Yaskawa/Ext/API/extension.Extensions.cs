/**
 * <auto-generated>
 * Autogenerated by Thrift Compiler (0.17.0)
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 * </auto-generated>
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Thrift;
using Thrift.Collections;
using Thrift.Protocol;


#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE0017  // object init can be simplified
#pragma warning disable IDE0028  // collection init can be simplified
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable CA1822   // empty DeepCopy() methods still non-static
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

namespace Yaskawa.Ext.API
{
  public static class extensionExtensions
  {
    public static bool Equals(this Dictionary<int, string> instance, object that)
    {
      if (!(that is Dictionary<int, string> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this Dictionary<int, string> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static Dictionary<int, string> DeepCopy(this Dictionary<int, string> source)
    {
      if (source == null)
        return null;

      var tmp4181 = new Dictionary<int, string>(source.Count);
      foreach (var pair in source)
        tmp4181.Add(pair.Key, (pair.Value != null) ? pair.Value : null);
      return tmp4181;
    }


    public static bool Equals(this Dictionary<string, global::Yaskawa.Ext.API.Any> instance, object that)
    {
      if (!(that is Dictionary<string, global::Yaskawa.Ext.API.Any> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this Dictionary<string, global::Yaskawa.Ext.API.Any> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static Dictionary<string, global::Yaskawa.Ext.API.Any> DeepCopy(this Dictionary<string, global::Yaskawa.Ext.API.Any> source)
    {
      if (source == null)
        return null;

      var tmp4182 = new Dictionary<string, global::Yaskawa.Ext.API.Any>(source.Count);
      foreach (var pair in source)
        tmp4182.Add((pair.Key != null) ? pair.Key : null, (pair.Value != null) ? pair.Value.DeepCopy() : null);
      return tmp4182;
    }


    public static bool Equals(this Dictionary<string, global::Yaskawa.Ext.API.Data> instance, object that)
    {
      if (!(that is Dictionary<string, global::Yaskawa.Ext.API.Data> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this Dictionary<string, global::Yaskawa.Ext.API.Data> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static Dictionary<string, global::Yaskawa.Ext.API.Data> DeepCopy(this Dictionary<string, global::Yaskawa.Ext.API.Data> source)
    {
      if (source == null)
        return null;

      var tmp4183 = new Dictionary<string, global::Yaskawa.Ext.API.Data>(source.Count);
      foreach (var pair in source)
        tmp4183.Add((pair.Key != null) ? pair.Key : null, (pair.Value != null) ? pair.Value.DeepCopy() : null);
      return tmp4183;
    }


    public static bool Equals(this HashSet<global::Yaskawa.Ext.API.ControllerEventType> instance, object that)
    {
      if (!(that is HashSet<global::Yaskawa.Ext.API.ControllerEventType> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this HashSet<global::Yaskawa.Ext.API.ControllerEventType> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static HashSet<global::Yaskawa.Ext.API.ControllerEventType> DeepCopy(this HashSet<global::Yaskawa.Ext.API.ControllerEventType> source)
    {
      if (source == null)
        return null;

      var tmp4184 = new HashSet<global::Yaskawa.Ext.API.ControllerEventType>(source.Count);
      foreach (var elem in source)
        tmp4184.Add(elem);
      return tmp4184;
    }


    public static bool Equals(this HashSet<global::Yaskawa.Ext.API.PendantEventType> instance, object that)
    {
      if (!(that is HashSet<global::Yaskawa.Ext.API.PendantEventType> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this HashSet<global::Yaskawa.Ext.API.PendantEventType> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static HashSet<global::Yaskawa.Ext.API.PendantEventType> DeepCopy(this HashSet<global::Yaskawa.Ext.API.PendantEventType> source)
    {
      if (source == null)
        return null;

      var tmp4185 = new HashSet<global::Yaskawa.Ext.API.PendantEventType>(source.Count);
      foreach (var elem in source)
        tmp4185.Add(elem);
      return tmp4185;
    }


    public static bool Equals(this HashSet<string> instance, object that)
    {
      if (!(that is HashSet<string> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this HashSet<string> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static HashSet<string> DeepCopy(this HashSet<string> source)
    {
      if (source == null)
        return null;

      var tmp4186 = new HashSet<string>(source.Count);
      foreach (var elem in source)
        tmp4186.Add((elem != null) ? elem : null);
      return tmp4186;
    }


    public static bool Equals(this List<List<double>> instance, object that)
    {
      if (!(that is List<List<double>> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<List<double>> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<List<double>> DeepCopy(this List<List<double>> source)
    {
      if (source == null)
        return null;

      var tmp4187 = new List<List<double>>(source.Count);
      foreach (var elem in source)
        tmp4187.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp4187;
    }


    public static bool Equals(this List<double> instance, object that)
    {
      if (!(that is List<double> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<double> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<double> DeepCopy(this List<double> source)
    {
      if (source == null)
        return null;

      var tmp4188 = new List<double>(source.Count);
      foreach (var elem in source)
        tmp4188.Add(elem);
      return tmp4188;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.Any> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.Any> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.Any> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.Any> DeepCopy(this List<global::Yaskawa.Ext.API.Any> source)
    {
      if (source == null)
        return null;

      var tmp4189 = new List<global::Yaskawa.Ext.API.Any>(source.Count);
      foreach (var elem in source)
        tmp4189.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp4189;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.ControlGroup> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.ControlGroup> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.ControlGroup> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.ControlGroup> DeepCopy(this List<global::Yaskawa.Ext.API.ControlGroup> source)
    {
      if (source == null)
        return null;

      var tmp4190 = new List<global::Yaskawa.Ext.API.ControlGroup>(source.Count);
      foreach (var elem in source)
        tmp4190.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp4190;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.ControllerEvent> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.ControllerEvent> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.ControllerEvent> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.ControllerEvent> DeepCopy(this List<global::Yaskawa.Ext.API.ControllerEvent> source)
    {
      if (source == null)
        return null;

      var tmp4191 = new List<global::Yaskawa.Ext.API.ControllerEvent>(source.Count);
      foreach (var elem in source)
        tmp4191.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp4191;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.DataPoint> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.DataPoint> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.DataPoint> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.DataPoint> DeepCopy(this List<global::Yaskawa.Ext.API.DataPoint> source)
    {
      if (source == null)
        return null;

      var tmp4192 = new List<global::Yaskawa.Ext.API.DataPoint>(source.Count);
      foreach (var elem in source)
        tmp4192.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp4192;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.GaugeSensorSpec> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.GaugeSensorSpec> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.GaugeSensorSpec> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.GaugeSensorSpec> DeepCopy(this List<global::Yaskawa.Ext.API.GaugeSensorSpec> source)
    {
      if (source == null)
        return null;

      var tmp4193 = new List<global::Yaskawa.Ext.API.GaugeSensorSpec>(source.Count);
      foreach (var elem in source)
        tmp4193.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp4193;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.JointType> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.JointType> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.JointType> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.JointType> DeepCopy(this List<global::Yaskawa.Ext.API.JointType> source)
    {
      if (source == null)
        return null;

      var tmp4194 = new List<global::Yaskawa.Ext.API.JointType>(source.Count);
      foreach (var elem in source)
        tmp4194.Add(elem);
      return tmp4194;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.LoggingEvent> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.LoggingEvent> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.LoggingEvent> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.LoggingEvent> DeepCopy(this List<global::Yaskawa.Ext.API.LoggingEvent> source)
    {
      if (source == null)
        return null;

      var tmp4195 = new List<global::Yaskawa.Ext.API.LoggingEvent>(source.Count);
      foreach (var elem in source)
        tmp4195.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp4195;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.PendantEvent> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.PendantEvent> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.PendantEvent> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.PendantEvent> DeepCopy(this List<global::Yaskawa.Ext.API.PendantEvent> source)
    {
      if (source == null)
        return null;

      var tmp4196 = new List<global::Yaskawa.Ext.API.PendantEvent>(source.Count);
      foreach (var elem in source)
        tmp4196.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp4196;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.PropValues> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.PropValues> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.PropValues> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.PropValues> DeepCopy(this List<global::Yaskawa.Ext.API.PropValues> source)
    {
      if (source == null)
        return null;

      var tmp4197 = new List<global::Yaskawa.Ext.API.PropValues>(source.Count);
      foreach (var elem in source)
        tmp4197.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp4197;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.SimpleControlGroup> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.SimpleControlGroup> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.SimpleControlGroup> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.SimpleControlGroup> DeepCopy(this List<global::Yaskawa.Ext.API.SimpleControlGroup> source)
    {
      if (source == null)
        return null;

      var tmp4198 = new List<global::Yaskawa.Ext.API.SimpleControlGroup>(source.Count);
      foreach (var elem in source)
        tmp4198.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp4198;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.storageInfo> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.storageInfo> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.storageInfo> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.storageInfo> DeepCopy(this List<global::Yaskawa.Ext.API.storageInfo> source)
    {
      if (source == null)
        return null;

      var tmp4199 = new List<global::Yaskawa.Ext.API.storageInfo>(source.Count);
      foreach (var elem in source)
        tmp4199.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp4199;
    }


    public static bool Equals(this List<long> instance, object that)
    {
      if (!(that is List<long> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<long> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<long> DeepCopy(this List<long> source)
    {
      if (source == null)
        return null;

      var tmp4200 = new List<long>(source.Count);
      foreach (var elem in source)
        tmp4200.Add(elem);
      return tmp4200;
    }


    public static bool Equals(this List<string> instance, object that)
    {
      if (!(that is List<string> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<string> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<string> DeepCopy(this List<string> source)
    {
      if (source == null)
        return null;

      var tmp4201 = new List<string>(source.Count);
      foreach (var elem in source)
        tmp4201.Add((elem != null) ? elem : null);
      return tmp4201;
    }


  }
}
