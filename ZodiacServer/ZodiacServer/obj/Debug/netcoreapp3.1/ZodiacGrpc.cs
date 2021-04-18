// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/zodiac.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ZodiacServer {
  public static partial class StarSignService
  {
    static readonly string __ServiceName = "zodiac.StarSignService";

    static readonly grpc::Marshaller<global::ZodiacServer.InputDate> __Marshaller_zodiac_InputDate = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ZodiacServer.InputDate.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::ZodiacServer.StarSignResponse> __Marshaller_zodiac_StarSignResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ZodiacServer.StarSignResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::ZodiacServer.InputDate, global::ZodiacServer.StarSignResponse> __Method_GetStarSignRequest = new grpc::Method<global::ZodiacServer.InputDate, global::ZodiacServer.StarSignResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetStarSignRequest",
        __Marshaller_zodiac_InputDate,
        __Marshaller_zodiac_StarSignResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ZodiacServer.ZodiacReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of StarSignService</summary>
    [grpc::BindServiceMethod(typeof(StarSignService), "BindService")]
    public abstract partial class StarSignServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::ZodiacServer.StarSignResponse> GetStarSignRequest(global::ZodiacServer.InputDate request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for StarSignService</summary>
    public partial class StarSignServiceClient : grpc::ClientBase<StarSignServiceClient>
    {
      /// <summary>Creates a new client for StarSignService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public StarSignServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for StarSignService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public StarSignServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected StarSignServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected StarSignServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::ZodiacServer.StarSignResponse GetStarSignRequest(global::ZodiacServer.InputDate request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetStarSignRequest(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::ZodiacServer.StarSignResponse GetStarSignRequest(global::ZodiacServer.InputDate request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetStarSignRequest, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::ZodiacServer.StarSignResponse> GetStarSignRequestAsync(global::ZodiacServer.InputDate request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetStarSignRequestAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::ZodiacServer.StarSignResponse> GetStarSignRequestAsync(global::ZodiacServer.InputDate request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetStarSignRequest, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override StarSignServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new StarSignServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(StarSignServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetStarSignRequest, serviceImpl.GetStarSignRequest).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, StarSignServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetStarSignRequest, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ZodiacServer.InputDate, global::ZodiacServer.StarSignResponse>(serviceImpl.GetStarSignRequest));
    }

  }
}
#endregion
