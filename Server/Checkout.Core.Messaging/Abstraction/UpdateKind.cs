namespace Checkout.Core.Messaging.Abstraction
{
    internal static class UpdateKind
    {
        public static string Update = "UPDATE";
        public static string Completion = "COMPLETED";
        public static string Error = "ERROR";
        public static string Ack = "ACKNOWLEDGEMENT";
    }
}
