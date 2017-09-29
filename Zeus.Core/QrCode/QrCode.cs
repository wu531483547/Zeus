#region 版权说明
/*****************************************************************************
* Copyright (c) 2017 All Rights Reserved.
* CLR版本： 4.0.30319.42000 
*机器名称：DESKTOP-FUHBS8L
*公司名称：
*命名空间：Zeus.Core.QrCode  
*文件名：  QrCode 
*版本号：  V1.0.0.0
*唯一标识：53b3e7e1-bd0b-4b9b-b65a-c7dfb1b8ece7
*当前的用户域：DESKTOP-FUHBS8L
*创建人：  Rex
*创建时间：2017/9/29 9:55:49 

*描述：
*
*=====================================================================
*修改标记
*修改时间：2017/9/29 9:55:49 
*修改人： HY-REX 
*版本号： V1.0.0.0
*描述：
*
*****************************************************************************/
#endregion

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using ThoughtWorks.QRCode.Codec;

namespace Zeus.Core
{
    public class QrCode
    {
        public void CreateCode_Choose(string strData, string qrEncoding, string level, int version, int scale)
        {
            QRCodeEncoder encoder = new QRCodeEncoder();
            string str = qrEncoding;
            if (!(str == "Byte"))
            {
                if (str == "AlphaNumeric")
                {
                    encoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.ALPHA_NUMERIC;
                }
                else if (str == "Numeric")
                {
                    encoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.NUMERIC;
                }
                else
                {
                    encoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
                }
            }
            else
            {
                encoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            }
            encoder.QRCodeScale = scale;
            encoder.QRCodeVersion = version;
            if (!(level == "L"))
            {
                if (level == "M")
                {
                    encoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
                }
                else if (level == "Q")
                {
                    encoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q;
                }
                else
                {
                    encoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H;
                }
            }
            else
            {
                encoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;
            }
            string str2 = "Temp.jpg";
            FileStream stream = new FileStream(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Resource" + "/" + str2, FileMode.OpenOrCreate, FileAccess.Write);
            Bitmap bitmap1 = encoder.Encode(strData);
            bitmap1.Save(stream, ImageFormat.Jpeg);
            stream.Close();
            bitmap1.Dispose();
        }
    }
}
