using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Omnibus.Serialization
{
    public interface ISerializer
    {
        string Serialize<T>(T value) where T : class;
        Task SerializeAsync<TValue>(Stream utf8Json, TValue value, CancellationToken token) where TValue : class;
        TValue? Deserialize<TValue>(string value) where TValue : class;
        ValueTask<TValue?> DeserializeAsync<TValue>(Stream stream, CancellationToken token) where TValue : class;
        byte[] SerializeBytes<T>(T value) where T : class;
        TValue? DeserializeBytes<TValue>(byte[] value) where TValue : class;
    }
}
