using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;  //二进制序列化命名空间
using System.Xml.Serialization;                        //Xml序列化命名空间

namespace Module_MKTools
{
    /// <summary>
    ///通过序列化和反序列化通用类
    /// </summary>
    public class Serialization
    {
        /// <summary>
        /// 将实例转换成XMl文件
        /// </summary>
        /// <typeparam name="T">泛型类名</typeparam>
        /// <param name="t">类实例</param>
        /// <param name="filePath">文件全路径</param>
        /// <returns></returns>
        public static bool ClassToXmlFile<T>(T t, string filePath) where T : class, new()
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    xs.Serialize(sw, t);
                }
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// 将XMl文件转换成实例
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filePath">文件全路径</param>
        /// <returns></returns>
        public static T XmlFileToClass<T>(string filePath) where T : class, new()
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));
                using (StreamReader sr = new StreamReader(filePath))
                {
                    return (T)xs.Deserialize(sr);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// 将实例转换成特定的二进制文件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="filePath">文件全路径</param>
        /// <returns></returns>
        public static bool ClassToBinary<T>(T t, string filePath) where T : class, new()
        {
            try
            {
                BinaryFormatter xs = new BinaryFormatter();
                using (FileStream sm = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    xs.Serialize(sm, t);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 将特定的二进制文件转化成实例
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filePath">文件全路径</param>
        /// <returns></returns>
        public static T BinaryToClass<T>(string filePath) where T : class, new()
        {
            //文件不存在，则生成一个该类的实例
            if (!File.Exists(filePath))
            {
                ClassToBinary<T>(new T(), filePath);
            }

            BinaryFormatter xs = new BinaryFormatter();
            using (FileStream sm = new FileStream(filePath, FileMode.Open))
            {
                return (T)xs.Deserialize(sm);//待添加文件不存在逻辑逻辑
            }
        }

    }
}
