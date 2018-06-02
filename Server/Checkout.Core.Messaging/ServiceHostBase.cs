using System;
using System.Reactive.Disposables;
using System.Threading.Tasks;
using Checkout.Core.Messaging.Abstraction;
using Serilog;

namespace Checkout.Core.Messaging
{
    public abstract class ServiceHostBase : IDisposable
    {
        private readonly IBroker _broker;
        private readonly Heartbeat _heartbeat;
        private readonly CompositeDisposable _registedCalls = new CompositeDisposable();
        public readonly string InstanceId;

        public readonly string ServiceType;

        protected ServiceHostBase(IBroker broker, string type)
        {
            ServiceType = type;
            _broker = broker;
            InstanceId = type + "." + Guid.NewGuid().ToString().Substring(0, 4);
            _heartbeat = new Heartbeat(this, broker);
        }

        public virtual void Dispose()
        {
            _registedCalls.Dispose();
            _heartbeat.Dispose();
        }

        protected void RegisterCall(string procName, Func<IRequestContext, IMessage, Task> procedure)
        {
            var instanceProcedureName = $"{InstanceId}.{procName}";
            var call = _broker.RegisterCall(instanceProcedureName, procedure);
            _registedCalls.Add(Disposable.Create(() =>
            {
                Log.Information("unregistering from {procName}", procName);
                call.Result.DisposeAsync().Wait(TimeSpan.FromSeconds(5));
                Log.Information("unregistered from {procName}", procName);
            }));
            Log.Information("procedure {procName}() registered", procName);
        }

        protected void RegisterCallResponse<T>(string procName, Func<IRequestContext, IMessage, Task<T>> procedure)
        {
            var instanceProcedureName = $"{InstanceId}.{procName}";
            var call = _broker.RegisterCallResponse(instanceProcedureName, procedure);
            _registedCalls.Add(Disposable.Create(() =>
            {
                Log.Information("unregistering from {procName}", procName);
                call.Result.DisposeAsync().Wait(TimeSpan.FromSeconds(5));
                Log.Information("unregistered from {procName}", procName);
            }));
            Log.Information("procedure {procName}() registered", procName);
        }

        protected void StartHeartBeat()
        {
            _heartbeat.Start().Wait();
        }

        public virtual double GetLoad()
        {
            return 0;
        }

        public override string ToString()
        {
            return $"{InstanceId}";
        }
    }
}
