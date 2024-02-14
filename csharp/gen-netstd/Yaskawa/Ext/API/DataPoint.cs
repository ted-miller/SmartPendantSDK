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
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;


#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE0017  // object init can be simplified
#pragma warning disable IDE0028  // collection init can be simplified
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable CA1822   // empty DeepCopy() methods still non-static
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

namespace Yaskawa.Ext.API
{

  public partial class DataPoint : TBase
  {
    private double _x;
    private double _y;
    private double _z;

    public double X
    {
      get
      {
        return _x;
      }
      set
      {
        __isset.x = true;
        this._x = value;
      }
    }

    public double Y
    {
      get
      {
        return _y;
      }
      set
      {
        __isset.y = true;
        this._y = value;
      }
    }

    public double Z
    {
      get
      {
        return _z;
      }
      set
      {
        __isset.z = true;
        this._z = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool x;
      public bool y;
      public bool z;
    }

    public DataPoint()
    {
    }

    public DataPoint DeepCopy()
    {
      var tmp133 = new DataPoint();
      if(__isset.x)
      {
        tmp133.X = this.X;
      }
      tmp133.__isset.x = this.__isset.x;
      if(__isset.y)
      {
        tmp133.Y = this.Y;
      }
      tmp133.__isset.y = this.__isset.y;
      if(__isset.z)
      {
        tmp133.Z = this.Z;
      }
      tmp133.__isset.z = this.__isset.z;
      return tmp133;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.Double)
              {
                X = await iprot.ReadDoubleAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Double)
              {
                Y = await iprot.ReadDoubleAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.Double)
              {
                Z = await iprot.ReadDoubleAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async global::System.Threading.Tasks.Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var tmp134 = new TStruct("DataPoint");
        await oprot.WriteStructBeginAsync(tmp134, cancellationToken);
        var tmp135 = new TField();
        if(__isset.x)
        {
          tmp135.Name = "x";
          tmp135.Type = TType.Double;
          tmp135.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp135, cancellationToken);
          await oprot.WriteDoubleAsync(X, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.y)
        {
          tmp135.Name = "y";
          tmp135.Type = TType.Double;
          tmp135.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp135, cancellationToken);
          await oprot.WriteDoubleAsync(Y, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.z)
        {
          tmp135.Name = "z";
          tmp135.Type = TType.Double;
          tmp135.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp135, cancellationToken);
          await oprot.WriteDoubleAsync(Z, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      if (!(that is DataPoint other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.x == other.__isset.x) && ((!__isset.x) || (global::System.Object.Equals(X, other.X))))
        && ((__isset.y == other.__isset.y) && ((!__isset.y) || (global::System.Object.Equals(Y, other.Y))))
        && ((__isset.z == other.__isset.z) && ((!__isset.z) || (global::System.Object.Equals(Z, other.Z))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.x)
        {
          hashcode = (hashcode * 397) + X.GetHashCode();
        }
        if(__isset.y)
        {
          hashcode = (hashcode * 397) + Y.GetHashCode();
        }
        if(__isset.z)
        {
          hashcode = (hashcode * 397) + Z.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp136 = new StringBuilder("DataPoint(");
      int tmp137 = 0;
      if(__isset.x)
      {
        if(0 < tmp137++) { tmp136.Append(", "); }
        tmp136.Append("X: ");
        X.ToString(tmp136);
      }
      if(__isset.y)
      {
        if(0 < tmp137++) { tmp136.Append(", "); }
        tmp136.Append("Y: ");
        Y.ToString(tmp136);
      }
      if(__isset.z)
      {
        if(0 < tmp137++) { tmp136.Append(", "); }
        tmp136.Append("Z: ");
        Z.ToString(tmp136);
      }
      tmp136.Append(')');
      return tmp136.ToString();
    }
  }

}
