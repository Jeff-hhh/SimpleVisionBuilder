using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;
using Cognex.VisionPro.ImageFile;
using Cognex.VisionPro.CalibFix;
using Cognex.VisionPro.Dimensioning;

namespace Module_MKTools
{
    /// <summary>
    /// 基于Visionpro(dll Ver9.0 SR2)的一些常用方法
    /// </summary>
    public class VPROSupportTools
    {

        #region [清理CogRecordDisplay内容]

        /// <summary>
        /// 清理CogRecordDisplay界面
        /// </summary>
        /// <param name="RecordDisplay"></param>
        public static void ClearDisplay(CogRecordDisplay myRecordDisplay)
        {
            myRecordDisplay.StaticGraphics.Clear();
            myRecordDisplay.InteractiveGraphics.Clear();
            myRecordDisplay.Image = null;
        }

        #endregion


        #region [在CogRecordDisplay显示文字信息]

        /// <summary>
        /// 在CogRecordDisplay显示文字信息
        /// </summary>
        /// <param name="str">文字内容</param>
        /// <param name="Rownum">显示起始行号</param>
        /// <param name="Colnum">显示起始列号</param>
        /// <param name="fondtype">显示字体</param>
        /// <param name="fondSize">显示字体大小</param>
        /// <param name="recordDisplay">CogRecordDisplay实例</param>
        /// <param name="FontColor">字体颜色</param>
        public static void DispMessage(string str, int Rownum, int Colnum, string fondtype, float fondSize, CogRecordDisplay recordDisplay, CogColorConstants FontColor)
        {
            CogGraphicLabel mylabel = new CogGraphicLabel();
            mylabel.SelectedSpaceName = "#";
            mylabel.Alignment = CogGraphicLabelAlignmentConstants.TopLeft;
            mylabel.Color = FontColor;
            mylabel.Font = new System.Drawing.Font(fondtype, fondSize);
            mylabel.SetXYText(30 + Rownum * 30, 30 + Colnum * 60, str);
            CogGraphicCollection mygraphic = new CogGraphicCollection();
            mygraphic.Add(mylabel);
            recordDisplay.StaticGraphics.AddList(mygraphic, "groups");
            recordDisplay.Fit(false);
        }

        #endregion


        #region [加载单张图像]

        //加载单张图像
        public static CogImage8Grey LoadImage()
        {
            CogImageFile mImageFile = new CogImageFile();
            OpenFileDialog openImage = new OpenFileDialog();
            try
            {
                openImage.Multiselect = false;
                openImage.Filter = "(*.bmp;*.png;*.jgp;*.jpeg;*.tif；*.JPG)|*.bmp;*.png;*.jpg;*.jpeg;*.tif;*.JPG";
                if (openImage.ShowDialog() == DialogResult.OK)
                {
                    mImageFile.Open(openImage.FileName, CogImageFileModeConstants.Read);
                }

                CogImageFile myImageFileOperator = new CogImageFile();
                if (openImage.FileName != "")
                {
                    myImageFileOperator.Open(openImage.FileName, CogImageFileModeConstants.Read);
                    return (CogImage8Grey)myImageFileOperator[0];
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                return null;
            }
        }

        #endregion


        #region [Image转换成CogImage8Grey(单通道)]

        /// <summary>
        /// Image转换成CogImage8Grey
        /// </summary>
        /// <param name="bitmap">bitmap图像</param>
        /// <returns>转换结果--格式CogImage8Grey</returns>
        public static CogImage8Grey ImageConvertoCogImage8Grey(Bitmap bitmap)
        {
            CogImage8Grey cogImage8Grey;
            try
            {
                cogImage8Grey = new CogImage8Grey(bitmap);
            }
            catch (Exception)
            {

                cogImage8Grey = null;
            }
            return cogImage8Grey;
        }

        #endregion


        #region [九点标定ToolBlock运行]

        /// <summary>
        /// 九点标定ToolBlock运行
        /// </summary>
        /// <param name="mAcq">相机</param>
        /// <param name="mCogRecordDisplay">图像显示窗体</param>
        /// <param name="cogNPCalibTB">九点标定ToolBlock</param>
        /// <param name="index">运行步骤</param>
        /// <param name="robotX">机械坐标点X</param>
        /// <param name="robotY">机械坐标点Y</param>
        /// <returns>运行结果</returns>
        public static bool NPCalibTBRun(CogAcqFifoTool mAcq, CogRecordDisplay mCogRecordDisplay, CogToolBlock cogNPCalibTB, int index, double robotX, double robotY)
        {
            bool result;
            try
            {
                var mGetPToolBlock = (CogToolBlock)cogNPCalibTB.Tools[0];
                var cogCalibNPointToNPointTool = (CogCalibNPointToNPointTool)cogNPCalibTB.Tools[1];
                mAcq.Run();
                ClearDisplay(mCogRecordDisplay);

                //运行图像找mark点工具
                mGetPToolBlock.Inputs[0].Value = mAcq.OutputImage;
                mGetPToolBlock.Run();
                cogCalibNPointToNPointTool.InputImage = mAcq.OutputImage;

                //判断找点工具的运行状态
                if (mGetPToolBlock.RunStatus.Result == CogToolResultConstants.Accept)
                {
                    cogCalibNPointToNPointTool.Calibration.SetRawCalibratedPoint(index - 1, robotX, robotY);
                    cogCalibNPointToNPointTool.Calibration.SetUncalibratedPoint(index - 1, (double)mGetPToolBlock.Outputs["X"].Value, (double)mGetPToolBlock.Outputs["Y"].Value);
                    cogCalibNPointToNPointTool.Run();

                    mCogRecordDisplay.Image = mAcq.OutputImage;
                    mCogRecordDisplay.Record = mGetPToolBlock.CreateLastRunRecord().SubRecords[0];

                    if (index < 9)
                    {
                        cogCalibNPointToNPointTool.Calibration.SetRawCalibratedPoint(index - 1, robotX, robotY);
                        cogCalibNPointToNPointTool.Calibration.SetUncalibratedPoint(index - 1, (double)mGetPToolBlock.Outputs["X"].Value, (double)mGetPToolBlock.Outputs["Y"].Value);
                        cogCalibNPointToNPointTool.Run();

                        DispMessage($"九点标定第{index}步成功", 0, 1, "微软雅黑", 12, mCogRecordDisplay, CogColorConstants.Green);
                        result = true;
                    }
                    else
                    {
                        cogCalibNPointToNPointTool.Calibration.Calibrate();
                        cogCalibNPointToNPointTool.Run();
                        if (cogCalibNPointToNPointTool.Calibration.ComputedRMSError <= 16)
                        {
                            DispMessage($"九点标定成功,RMS值为{cogCalibNPointToNPointTool.Calibration.ComputedRMSError.ToString("f2")}", 0, 2, "微软雅黑", 12, mCogRecordDisplay, CogColorConstants.Green);
                            result = true;
                        }
                        else
                        {
                            DispMessage($"九点标定失败，RMS{cogCalibNPointToNPointTool.Calibration.ComputedRMSError.ToString("f2")}过大", 0, 2, "微软雅黑", 12, mCogRecordDisplay, CogColorConstants.Red);
                            result = false;
                        }
                    }
                }
                else
                {
                    mCogRecordDisplay.Image = mAcq.OutputImage;
                    result = false;
                    DispMessage($"九点标定第{index}步失败,Mark点查询失败", 0, 1, "微软雅黑", 12, mCogRecordDisplay, CogColorConstants.Red);
                }
                mCogRecordDisplay.Fit(true);
            }
            catch (Exception ex)
            {
                DispMessage($"九点标定第{index}步异常" + ex.ToString(), 0, 1, "微软雅黑", 12, mCogRecordDisplay, CogColorConstants.Red);
                result = false;
            }
            return result;
        }

        #endregion


        #region [拟合圆方法计算旋转中心]

        public static bool RoTBRun(CogAcqFifoTool mAcq, CogRecordDisplay mCogRecordDisplay, CogToolBlock cogRoTB, int index, out double roX, out double roY)
        {
            bool result;
            roX = 0;
            roY = 0;

            try
            {
                var mNPTool = (CogCalibNPointToNPointTool)cogRoTB.Tools[0];
                var mGetPToolBlock = (CogToolBlock)cogRoTB.Tools[1];
                var cogFitCircleTool = (CogFitCircleTool)cogRoTB.Tools[2];
                mAcq.Run();
                ClearDisplay(mCogRecordDisplay);

                //运行NP工具
                mNPTool.InputImage = mAcq.OutputImage;
                mNPTool.Run();

                //运行图像找mark点工具
                mGetPToolBlock.Inputs[0].Value = mNPTool.OutputImage;
                mGetPToolBlock.Run();

                cogFitCircleTool.InputImage = mNPTool.OutputImage;
                //判断找点工具的运行状态
                if (mGetPToolBlock.RunStatus.Result == CogToolResultConstants.Accept)
                {
                    mCogRecordDisplay.Image = mNPTool.OutputImage;
                    mCogRecordDisplay.Record = mGetPToolBlock.CreateLastRunRecord().SubRecords[0];

                    cogFitCircleTool.RunParams.SetPoint(index - 1, (double)mGetPToolBlock.Outputs[0].Value, (double)mGetPToolBlock.Outputs[1].Value);
                    DispMessage($"旋转中心第{index}步成功", 0, 1, "微软雅黑", 12, mCogRecordDisplay, CogColorConstants.Green);

                    if (index < 7)
                    {
                        result = true;
                    }
                    else
                    {
                        cogFitCircleTool.Run();
                        if (cogFitCircleTool.RunStatus.Result == CogToolResultConstants.Accept)
                        {
                            roX = Math.Round(cogFitCircleTool.Result.GetCircle().CenterX, 3);
                            roY = Math.Round(cogFitCircleTool.Result.GetCircle().CenterY, 3);
                            DispMessage($"旋转中心标定成功,X:{cogFitCircleTool.Result.GetCircle().CenterX},Y:{cogFitCircleTool.Result.GetCircle().CenterY}", 0, 2, "微软雅黑", 12, mCogRecordDisplay, CogColorConstants.Green);
                            result = true;
                        }
                        else
                        {
                            DispMessage("拟合圆计算旋转中心失败", 0, 2, "微软雅黑", 12, mCogRecordDisplay, CogColorConstants.Red);
                            result = false;
                        }
                    }
                }
                else
                {
                    result = false;
                    mCogRecordDisplay.Image = mAcq.OutputImage;
                    DispMessage($"旋转中心第{index}步失败,Mark点查询失败", 0, 1, "微软雅黑", 12, mCogRecordDisplay, CogColorConstants.Red);
                }
                mCogRecordDisplay.Fit(true);
            }
            catch (Exception ex)
            {
                result = false;
                MessageBox.Show(ex.ToString());
            }

            return result;
        }

        #endregion


        #region [九点标定工具导入]

        /// <summary>
        /// 九点标定工具导入
        /// </summary>
        /// <param name="Image">传入图像</param>
        /// <param name="CalibTool">九点标定源文件</param>
        /// <param name="TargetCalibTool">要导入的目标</param>
        /// <returns>导入结果</returns>
        public static bool CopyNPCalibToNew(CogImage8Grey Image, CogCalibNPointToNPointTool CalibTool, CogCalibNPointToNPointTool TargetCalibTool)
        {
            bool result;
            try
            {
                for (int i = 0; i < 9; i++)
                {
                    double robotX, robotY, imageX, imageY;
                    CalibTool.Calibration.GetRawCalibratedPoint(i, out imageX, out imageY);
                    CalibTool.Calibration.GetUncalibratedPoint(i, out robotX, out robotY);
                    TargetCalibTool.Calibration.SetRawCalibratedPoint(i, imageX, imageY);
                    TargetCalibTool.Calibration.SetUncalibratedPoint(i, robotX, robotY);
                }
                TargetCalibTool.InputImage = Image;
                TargetCalibTool.Calibration.Calibrate();
                TargetCalibTool.Run();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        #endregion


        #region [在CogRecordDisplay中绘制十字线]

        /// <summary>
        /// 显示十字中心线
        /// </summary>
        /// <param name="Display">CogRecordDisplay实例</param>
        public static void DrawCross(CogRecordDisplay Display, int ImageWidth, int ImageHeight)
        {
            try
            {
                Cognex.VisionPro.ICogImage image = Display.Image;

                if (image == null)
                {
                    Bitmap bmp = new Bitmap(ImageWidth, ImageHeight);
                    image = new Cognex.VisionPro.CogImage8Grey(bmp);
                    Display.Image = image;
                    Display.Fit();
                }
                else
                {
                    int cw = image.Width / 2;
                    int ch = image.Height / 2;
                    double cx, cy;
                    image.GetTransform(".", "*").MapPoint(cw, ch, out cx, out cy);

                    Cognex.VisionPro.CogPointMarker cross = new Cognex.VisionPro.CogPointMarker();
                    cross.Color = Cognex.VisionPro.CogColorConstants.Red;
                    cross.SetCenterRotationSize(cx, cy, 0, 2500);
                    Display.StaticGraphics.Clear();
                    Display.StaticGraphics.Add(cross, "_cross_");
                }
            }
            catch (Exception)
            {

            }
        }


        public static void DrawCross(CogRecordDisplay cogRecordDisplay)
        {
            try
            {
                CogPointMarker cross = new CogPointMarker();
                cross.Color = CogColorConstants.Red;
                double Width, Height;
                Width = cogRecordDisplay.Image.Width;
                Height = cogRecordDisplay.Image.Height;
                cross.SetCenterRotationSize(Width / 2, Height / 2, 0, 9999);
                cogRecordDisplay.StaticGraphics.Clear();
                cogRecordDisplay.StaticGraphics.Add(cross, "_cross_");
            }
            catch (Exception)
            {

            }
        }

        #endregion


        #region [相机实时]

        /// <summary>
        /// 相机实时
        /// </summary>
        /// <param name="acq">相机</param>
        /// <param name="cogRecordDisplay">图像显示框</param>
        /// <param name="isLiving">是否实时</param>
        /// <param name="isShowCross">是否十字</param>
        public static bool CCDLiving(CogAcqFifoTool acq, CogRecordDisplay cogRecordDisplay, bool isLiving, bool isShowCross)
        {
            try
            {
                if (acq != null)
                {
                    acq.Run();
                    cogRecordDisplay.Image = acq.OutputImage;
                    if (isLiving)
                    {
                        cogRecordDisplay.StaticGraphics.Clear();
                        cogRecordDisplay.InteractiveGraphics.Clear();
                        cogRecordDisplay.StartLiveDisplay(acq.Operator);
                        DrawCross(cogRecordDisplay);
                        cogRecordDisplay.Fit(false);
                    }
                    else
                    {
                        cogRecordDisplay.StopLiveDisplay();
                    }
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }


        #endregion

    }
}