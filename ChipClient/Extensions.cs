using ChipClient.ServiceReference;

namespace ChipClient
{
    static class Extensions
    {
        public static string ToString(this Subject subject)
        {
            return subject.Name;
        }
    }
}
