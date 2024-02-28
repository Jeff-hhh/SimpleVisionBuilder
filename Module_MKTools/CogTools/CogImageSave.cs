using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using Cognex.VisionPro;
using Cognex.VisionPro.ImageFile;

namespace Module_MKTools
{
    /// <summary>
    /// 图像类型枚举
    /// </summary>
    public enum ImageType
    {
        bmp,
        jpg,
        tiff,
        png
    }

    /// <summary>
    /// 基于Visionpro的图像存储类
    /// </summary>
    public class CogImageSave
    {
        private static object _lockToolImage = new object();
        /// <summary>
        /// 保存工具截图
        /// </summary>
        /// <param name="path">存储路径根目录</param>
        /// <param name="typeOKorNG">图像类型</param>
        /// <param name="mDisplay">CogRecordDisplay实例</param>
        public static void SaveToolImage(string path, bool typeOKorNG, CogRecordDisplay mDisplay, ImageType imageType)
        {
            try
            {
                lock (_lockToolImage)
                {
                    if (typeOKorNG)
                    {
                        path = path + @"\OK";
                    }
                    else
                    {
                        path = path + @"\NG";
                    }

                    if (!Directory.Exists(path)) //判断文件夹是否存在
                    {
                        Directory.CreateDirectory(path);//创建文件夹
                    }

                    string strImageName;
                    switch (imageType)
                    {
                        case ImageType.bmp:
                            strImageName = path + "\\" + DateTime.Now.ToString("HH-mm-ss") + ".bmp";
                            break;
                        case ImageType.jpg:
                            strImageName = path + "\\" + DateTime.Now.ToString("HH-mm-ss") + ".jpg";
                            break;
                        case ImageType.tiff:
                            strImageName = path + "\\" + DateTime.Now.ToString("HH-mm-ss") + ".tiff";
                            break;
                        case ImageType.png:
                            strImageName = path + "\\" + DateTime.Now.ToString("HH-mm-ss") + ".png";
                            break;
                        default:
                            strImageName = path + "\\" + DateTime.Now.ToString("HH-mm-ss") + ".bmp";
                            break;
                    }

                    Image mImage = mDisplay.CreateContentBitmap(Cognex.VisionPro.Display.CogDisplayContentBitmapConstants.Image);
                    mImage.Save(strImageName);
                }
            }
            catch (Exception ex)
            {

            }
        }

        public static void SaveToolImageWithID(string path, bool typeOKorNG, string idCode, CogRecordDisplay mDisplay, ImageType imageType)
        {
            try
            {
                lock (_lockToolImage)
                {
                    if (typeOKorNG)
                    {
                        path = path + @"\OK";
                    }
                    else
                    {
                        path = path + @"\NG";
                    }

                    if (!Directory.Exists(path)) //判断文件夹是否存在
                    {
                        Directory.CreateDirectory(path);//创建文件夹
                    }

                    string strImageName;
                    switch (imageType)
                    {
                        case ImageType.bmp:
                            strImageName = path + "\\" + idCode + "_" + DateTime.Now.ToString("HH-mm-ss") + ".bmp";
                            break;
                        case ImageType.jpg:
                            strImageName = path + "\\" + idCode + "_" + DateTime.Now.ToString("HH-mm-ss") + ".jpg";
                            break;
                        case ImageType.tiff:
                            strImageName = path + "\\" + idCode + "_" + DateTime.Now.ToString("HH-mm-ss") + ".tiff";
                            break;
                        case ImageType.png:
                            strImageName = path + "\\" + idCode + "_" + DateTime.Now.ToString("HH-mm-ss") + ".png";
                            break;
                        default:
                            strImageName = path + "\\" + idCode + "_" + DateTime.Now.ToString("HH-mm-ss") + ".bmp";
                            break;
                    }

                    Image mImage = mDisplay.CreateContentBitmap(Cognex.VisionPro.Display.CogDisplayContentBitmapConstants.Image);
                    mImage.Save(strImageName);
                }
            }
            catch (Exception ex)
            {

            }
        }


        private static object _lockOriImage = new object();
        /// <summary>
        /// 保存相机原图
        /// </summary>
        /// <param name="path">存储路径根目录</param>
        /// <param name="typeOKorNG">图像类型</param>
        /// <param name="mImage">输入图像</param>
        public static void SaveOriImage(string path, bool typeOKorNG, ICogImage mImage)
        {
            try
            {
                lock (_lockOriImage)
                {
                    if (typeOKorNG)
                    {
                        path = path + @"\OK";
                    }
                    else
                    {
                        path = path + @"\NG";
                    }

                    if (!Directory.Exists(path)) //判断文件夹是否存在
                    {
                        Directory.CreateDirectory(path);//创建文件夹
                    }

                    string strImageName = path + "\\" + DateTime.Now.ToString("HH-mm-ss") + ".bmp";
                    CogImageFile imagefileWrite = new CogImageFile();
                    imagefileWrite.Open(strImageName, CogImageFileModeConstants.Write);
                    imagefileWrite.Append(mImage);
                    GC.Collect();
                }
            }
            catch (Exception ex)
            {

            }
        }


        public static void SaveOriImageWithID(string path, bool typeOKorNG, string idCode, ICogImage mImage)
        {
            try
            {
                lock (_lockOriImage)
                {
                    if (typeOKorNG)
                    {
                        path = path + @"\OK";
                    }
                    else
                    {
                        path = path + @"\NG";
                    }

                    if (!Directory.Exists(path)) //判断文件夹是否存在
                    {
                        Directory.CreateDirectory(path);//创建文件夹
                    }

                    string strImageName = path + "\\" + idCode + "_" + DateTime.Now.ToString("HH-mm-ss") + ".bmp";
                    CogImageFile imagefileWrite = new CogImageFile();
                    imagefileWrite.Open(strImageName, CogImageFileModeConstants.Write);
                    imagefileWrite.Append(mImage);
                    GC.Collect();
                }
            }
            catch (Exception ex)
            {

            }
        }

    }
}
