using System;
using System.IO;
using ValheimCharacterEditor.Valheim;

namespace ValheimCharacterEditor.Utilities
{
    public class BinaryStream : IDisposable
    {
        private readonly BinaryWriter _writer;
        private readonly BinaryReader _reader;
        private readonly MemoryStream _stream;

        public long Length => _stream.Length;
        
        public BinaryStream()
        {
            _stream = new MemoryStream();
            _writer = new BinaryWriter(_stream);
            _reader = new BinaryReader(_stream);
        }

        public BinaryStream(byte[] data)
        {
            _stream = new MemoryStream();
            _writer = new BinaryWriter(_stream);
            _reader = new BinaryReader(_stream);

            _stream.Write(data, 0, data.Length);
            _stream.Position = 0;
        }

        public int ReadInt32() => _reader.ReadInt32();
        public long ReadInt64() => _reader.ReadInt64();
        public bool ReadBoolean() => _reader.ReadBoolean();
        public float ReadSingle() => _reader.ReadSingle();
        public string ReadString() => _reader.ReadString();

        public Vector3 ReadVector3()
        {
            Vector3 vector3 = new Vector3
            {
                X = _reader.ReadSingle(),
                Y = _reader.ReadSingle(),
                Z = _reader.ReadSingle()
            };

            return vector3;
        }

        public byte[] ReadBytes()
        {
            int length = _reader.ReadInt32();
            return _reader.ReadBytes(length);
        }

        public void Write(int data) => _writer.Write(data);
        public void Write(long data) => _writer.Write(data);
        public void Write(bool data) => _writer.Write(data);
        public void Write(float data) => _writer.Write(data);
        public void Write(string data) => _writer.Write(data);

        public void Write(Vector3 vector)
        {
            _writer.Write(vector.X);
            _writer.Write(vector.Y);
            _writer.Write(vector.Z);
        }

        public void Write(byte[] data)
        {
            _writer.Write(data.Length);
            _writer.Write(data);
        }

        public byte[] ToArray()
        {
            _writer.Flush();
            _stream.Flush();
            return _stream.ToArray();
        }

        public void Clear()
        {
            _writer.Flush();
            _stream.SetLength(0);
            _stream.Position = 0;
        }

        public void Dispose()
        {
            _writer?.Dispose();
            _reader?.Dispose();
            _stream?.Dispose();
        }
    }
}
