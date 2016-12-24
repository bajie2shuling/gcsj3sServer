using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;  //需要引入的命名空间
using System.Net.Sockets;
using System.Threading;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace gcsj3sServer
{
    public partial class Form1 : Form
    {
        //定义委托，跨线程访问ui
        public delegate void myInvokeUpdateTbx(String msg);
        public delegate void myInvokeClearTbx();

        bool isRecv = false;  //是否接收数据

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbxTemp.Text = "";
            tbxTempTime.Text = "";
            tbxGas.Text = "";
            tbxGasTime.Text = "";

            tbxTemp.ReadOnly = true;
            tbxTempTime.ReadOnly = true;
            tbxGas.ReadOnly = true;
            tbxGasTime.ReadOnly = true;

        }


        private void updateTbxConInfo(String msg)  //更新TCP连接框内信息
        {
            tbxConInfo.Text =msg + "\r\n" + tbxConInfo.Text;
        }

        private void updateTbxTemp(String msg)  //更新温度框内的信息
        {
            tbxTemp.Text = msg + "\r\n" + tbxTemp.Text;
        }

        private void updateTbxTempTime(String msg)  //更新温度时间框内的信息
        {
            tbxTempTime.Text = msg + "\r\n" + tbxTempTime.Text;
        }

        private void updateTbxGas(String msg)  //更新气体框内的信息
        {
            tbxGas.Text = msg + "\r\n" + tbxGas.Text;
        }

        private void updateTbxGasTime(String msg)  //更新气体时间框内的信息
        {
            tbxGasTime.Text = msg + "\r\n" + tbxGasTime.Text;
        }

        private void clearTbxTemp()  //清空
        {
            tbxTemp.Text = "";
        }

        private void clearTbxTempTime()  //清空
        {
            tbxTempTime.Text = "";
        }

        private void clearTbxGas()  //清空
        {
            tbxGas.Text = "";
        }

        private void clearTbxGasTime()  //清空
        {
            tbxGasTime.Text = "";
        }

        private String Decrypt(String decryptStr)  //AES解密函数
        {
            byte[] keyArray = UTF8Encoding.UTF8.GetBytes("12345678901234567890123456789012");
            byte[] toEncryptArray = Convert.FromBase64String(decryptStr);
            RijndaelManaged rDel = new RijndaelManaged();
            rDel.Key = keyArray;
            rDel.Mode = CipherMode.ECB;
            rDel.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = rDel.CreateDecryptor();  //创建解密器
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return UTF8Encoding.UTF8.GetString(resultArray);  //返回解密后的信息的字符串格式
        }

        private void startServer()
        {
            myInvokeUpdateTbx miCon = new myInvokeUpdateTbx(updateTbxConInfo);  //创建委托对象跨线程更新TbxConInfo内容
            myInvokeUpdateTbx miTemp = new myInvokeUpdateTbx(updateTbxTemp);
            myInvokeUpdateTbx miTempTime = new myInvokeUpdateTbx(updateTbxTempTime);
            myInvokeUpdateTbx miGas = new myInvokeUpdateTbx(updateTbxGas);
            myInvokeUpdateTbx miGasTime = new myInvokeUpdateTbx(updateTbxGasTime);
            int recvlen;  //用于表示客户端发送的信息长度  
            byte[] bytebuf = new byte[1024];   //用于缓存客户端所发送的信息,通过socket传递的信息必须为字节数组 
            Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 9050);  //本机预使用的IP和端口  
            newsock.Bind(ipep);  //绑定  
            newsock.Listen(10);  //监听 
             
            String wait = "waiting for a client";
            tbxConInfo.BeginInvoke(miCon,new object[] { wait});  //TbxConInfo中显示等待客户端连接

            Socket response = newsock.Accept();//当有可用的客户端连接尝试时执行，并返回一个新的socket,用于与客户端之间的通信  
            tbxConInfo.BeginInvoke(miCon,new object[] { "new client connecting "});

            IPEndPoint clientip = (IPEndPoint)response.RemoteEndPoint; //取得客户端的IPEndPoint

            String clientInfo = "connect with client:" + clientip.Address + " at port:" + clientip.Port;
            tbxConInfo.BeginInvoke(miCon, new object[] { clientInfo });  //TbxConInfo中显示客户端信息

            string welcome = "connected successful ,welcome here!";  //向客户端发送连接成功的反馈信息
            bytebuf = Encoding.ASCII.GetBytes(welcome);
            response.Send(bytebuf, bytebuf.Length, SocketFlags.None);//发送信息  

            while (true)
            {//用死循环来不断的从客户端获取信息 
                if (isRecv)
                { 
                    byte[] data = new byte[1024];
                    recvlen = response.Receive(data);
                    if (recvlen == 0)//当信息长度为0，说明客户端连接断开  
                        break;
                    String strbuf = Encoding.ASCII.GetString(data,0,recvlen);
                    String frame = Decrypt(strbuf);  //将接收的字节转化为字符串帧

                    String deviceId = frame.Substring(0,1);  //字符串按照设备ID不同进行分割
                    String collectData = null;
                    String collectTime = null;
                    if (deviceId == "1")
                    {
                        collectData = frame.Substring(1, 2);
                        collectTime = frame.Substring(3);

                        tbxTemp.BeginInvoke(miTemp,new object[] { collectData});//显示
                        tbxTempTime.BeginInvoke(miTempTime, new object[] { collectTime });

                        insertData(Convert.ToInt32(deviceId),collectData,collectTime);//插入数据库
                    }
                    else if(deviceId == "2")
                    {
                        collectData = frame.Substring(1, 3);
                        collectTime = frame.Substring(4);

                        tbxGas.BeginInvoke(miGas,new object[] { collectData});//显示
                        tbxGasTime.BeginInvoke(miGasTime,new object[] { collectTime});

                        insertData(Convert.ToInt32(deviceId), collectData, collectTime);//插入数据库
                    }
                }
            }

            String disCon = "Disconnected from" + clientip.Address;
            tbxConInfo.BeginInvoke(miCon,new object[] { disCon});   //TbxConInfo中显示断开连接信息

            response.Close();
            newsock.Close();
        }

        private void btnStartServer_Click(object sender, EventArgs e)  //开启服务器
        {
            Thread server = new Thread(startServer);  //创建服务器进程
            server.IsBackground = true;
            server.Start();
        }

        private void btnStratRecv_Click(object sender, EventArgs e)
        {
            isRecv = true;
            btnStopRecv.Enabled = true;
            btnStratRecv.Enabled = false;
        }

        private void btnStopRecv_Click(object sender, EventArgs e)
        {
            isRecv = false;
            btnStratRecv.Enabled = true;
            btnStopRecv.Enabled = false;
        }

        private void btnClearBuf_Click(object sender, EventArgs e)  //清空Tbx缓存
        {
            //创建委托对象跨线程更新Tbx内容
            myInvokeClearTbx miclearTemp = new myInvokeClearTbx(clearTbxTemp);
            myInvokeClearTbx miclearTempTime = new myInvokeClearTbx(clearTbxTempTime);
            myInvokeClearTbx miclearGas = new myInvokeClearTbx(clearTbxGas);
            myInvokeClearTbx miclearGasTime = new myInvokeClearTbx(clearTbxGasTime);

            tbxTemp.BeginInvoke(miclearTemp, null);
            tbxTempTime.BeginInvoke(miclearTempTime, null);
            tbxGas.BeginInvoke(miclearGas, null);
            tbxGasTime.BeginInvoke(miclearGasTime, null);

        }

        private void btnEsc_Click(object sender, EventArgs e)  //关闭窗体程序
        {
            this.Close();
        }

        private void insertData(int id, String collectData, String collectTime)
        {
            String con = "Server = localhost;Database = gcsj;Uid = root;Pwd = wjz520mysql";
            String sql = "INSERT INTO  device(deviceId,collectData,collectTime) VALUES('"+id+"','"+collectData+"','"+collectTime+"')";
            MySqlConnection myCon = new MySqlConnection(con);
            myCon.Open();
            MySqlCommand myCom = new MySqlCommand(sql, myCon);
            myCom.ExecuteNonQuery();
            myCom.Dispose();
            myCon.Close();
            myCon.Dispose();
        }
    }
}
