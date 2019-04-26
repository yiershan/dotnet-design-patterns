using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace PrototypePattern
{
    [Serializable]
    public class Sheep : ICloneable
    {
        public string Name { get; set; }
        public List<Sheep> Children { get; set; }
        public Sheep(string name)
        {
            this.Name = name;
            Children = new List<Sheep>();
        }
        /// <summary>
        /// 通过ICloneable接口实现
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Sheep(Name);
        }
        /// <summary>
        /// MemberwiseClone 实现浅拷贝
        /// </summary>
        /// <returns></returns>
        public Sheep Clone1() 
        {
            return this.MemberwiseClone() as Sheep;
        }
        /// <summary>
        /// 二进制序列化实现深拷贝
        /// </summary>
        /// <returns></returns>
        public Sheep Clone2() {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Position = 0;
            return formatter.Deserialize(stream) as Sheep;
        }
    }
}
