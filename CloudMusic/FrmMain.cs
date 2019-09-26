using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using Newtonsoft.Json;

namespace DKProCloudMusic
{
    public partial class FrmMain : CCWin.Skin_Mac
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private bool HostsMode => rbtnHosts.Checked;
        private DKSet dKSet = new DKSet();

        /// <summary>
        /// 设置自启
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAutoStart_Click(object sender, EventArgs e)
        {
            btnAutoStart.Checked = !btnAutoStart.Checked;
            if (btnAutoStart.Checked)
            {
                dKSet.AutoStart = true;//自动启用
                dKSet.StartWithMini = btnAutoMini.Checked; //最小化
                dKSet.Mode = btnAutoVpn.Checked ? 1 : btnAutoHosts.Checked ? 2 : 0; //启动模式
                dKSet.AutoExecute = dKSet.Mode > 0;  //自动执行
                Regedit.AutoRunAfterStart();
            }
            else
            {
                dKSet.AutoStart = false;
                Regedit.DeleteSubKey();
            }
            RegistryKey key = Registry.LocalMachine;
            RegistryKey software = key.OpenSubKey("software\\DKProCloudMusic", true);
            software.SetValue("DKSet", JsonConvert.SerializeObject(dKSet));
        }

        /// <summary>
        /// 自启最小化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAutoMini_Click(object sender, EventArgs e)
        {
            btnAutoMini.Checked = !btnAutoMini.Checked;
        }

        /// <summary>
        /// 检查更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("当前版本已是最新!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 启动服务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStart_Click(object sender, EventArgs e)
        {
            StartServer();
            this.Icon = notifyIcon1.Icon = new System.Drawing.Icon("jinse.ico");
            btnStart.Enabled = false;
            btnMenuStart.Enabled = false;
            btnMenuStop.Enabled = true;
            btnStop.Enabled = true;
            skinGroupBox1.Enabled = false;
            notifyIcon1.Text = "DKPro服务已启动";
            labStatus.Text = "运行中";
            labStatus.ForeColor = System.Drawing.Color.Red;
        }

        /// <summary>
        /// 停止服务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStop_Click(object sender, EventArgs e)
        {
            //如果为Hosts模式则恢复
            if (HostsMode)
            {
                RecoveryHosts();
            }
            //结束
            CloseSoundApp();
            this.Icon = notifyIcon1.Icon = new System.Drawing.Icon("huise.ico");
            btnStop.Enabled = false;
            btnMenuStop.Enabled = false;
            btnStart.Enabled = true;
            btnMenuStart.Enabled = true;
            skinGroupBox1.Enabled = true;
            notifyIcon1.Text = "DKPro服务未启动";
            labStatus.Text = "未启动";
            labStatus.ForeColor = System.Drawing.Color.Black;
        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Process[] myProcesses = System.Diagnostics.Process.GetProcessesByName("DKProCloudMusic");//获取指定的进程名
            if (myProcesses.Length > 1) //如果可以获取到知道的进程名则说明已经启动
            {
                MessageBox.Show("程序已启动，请勿重复打开！");
                //Application.Exit();              //关闭系统
                this.notifyIcon1.Visible = false;
                Environment.Exit(0);
            }
            else
            {
                try
                {
                    //启动时备份HOSTS文件
                    String sourceFile = @"C:\WINDOWS\system32\drivers\etc\hosts";
                    String destinationFile = @"C:\WINDOWS\system32\drivers\etc\hostsBak";
                    bool isrewrite = true; // true=覆盖已存在的同名文件,false则反之
                    System.IO.File.Copy(sourceFile, destinationFile, isrewrite);
                    //检测读取注册表信息
                    RegConfig();
                }
                catch
                {
                    MessageBox.Show("请以管理员身份运行!", "DKPro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// 运行命令行程序
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private String RunCmd(String str)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
            p.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
            p.StartInfo.RedirectStandardError = true;//重定向标准错误输出
            p.StartInfo.CreateNoWindow = true;//不显示程序窗口
            p.Start();//启动程序
            //向cmd窗口发送输入信息
            p.StandardInput.WriteLine(str + "&exit");
            p.StandardInput.AutoFlush = true;
            //获取cmd窗口的输出信息
            String output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();//等待程序执行完退出进程
            p.Close();
            return output;
        }

        /// <summary>
        /// 网址转ip
        /// </summary>
        /// <param name="domain"></param>
        /// <returns></returns>
        private String GetIP(String domain)
        {
            domain = domain.Replace("http://", "").Replace("https://", "");
            IPHostEntry hostEntry = Dns.GetHostEntry(domain);
            IPEndPoint ipEndPoint = new IPEndPoint(hostEntry.AddressList[0], 0);
            return ipEndPoint.Address.ToString();
        }

        /// <summary>
        /// 清理node进程残留
        /// </summary>
        public void CloseSoundApp()
        {
            Process[] ps = Process.GetProcesses();
            foreach (System.Diagnostics.Process p in ps)
            {
                if (p.ProcessName == "node")
                {
                    p.Kill();
                }
            }
        }

        /// <summary>
        /// 窗体最小化触发通知
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.notifyIcon1.Visible = true;
                this.notifyIcon1.ShowBalloonTip(300, "DKPro通知", "后台运行中，双击即可打开！", ToolTipIcon.Info);
            }
        }

        /// <summary>
        /// 双击托盘显示或隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Visible)
            {
                this.WindowState = FormWindowState.Minimized;
                this.notifyIcon1.Visible = true;
                this.Hide();
            }
            else
            {
                this.Visible = true;
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
        }

        /// <summary>
        /// 恢复hosts文件
        /// </summary>
        private void RecoveryHosts()
        {
            String sourceFile = @"C:\WINDOWS\system32\drivers\etc\hostsBak";
            String destinationFile = @"C:\WINDOWS\system32\drivers\etc\hosts";
            bool isrewrite = true; // true=覆盖已存在的同名文件,false则反之
            System.IO.File.Copy(sourceFile, destinationFile, isrewrite);
        }

        /// <summary>
        /// 读取或创建注册表
        /// </summary>
        private void RegConfig()
        {
            if (Regedit.IsRegeditItemExist())
            {
                if (Regedit.IsRegeditKeyExit())
                {
                    RegistryKey Key = Registry.LocalMachine;
                    RegistryKey myreg = Key.OpenSubKey("software\\DKProCloudMusic");
                    var value = myreg.GetValue("DKSet").ToString();
                    myreg.Close();
                    dKSet = JsonConvert.DeserializeObject<DKSet>(value);
                    if (dKSet != null)
                    {
                        btnAutoStart.Checked = dKSet.AutoStart;
                        btnAutoMini.Checked = dKSet.StartWithMini;
                        rbtnHosts.Checked = dKSet.Mode == 2;
                        if (dKSet.AutoExecute)
                        {
                            BtnStart_Click(null, null);
                        }
                        if (dKSet.StartWithMini)
                        {
                            this.WindowState = FormWindowState.Minimized;
                        }
                    }
                }
            }
            else
            {
                RegistryKey key = Registry.LocalMachine;
                key.CreateSubKey("software\\DKProCloudMusic");
            }
        }

        /// <summary>
        /// 托盘退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMenuExit_Click(object sender, EventArgs e)
        {
            BtnStop_Click(null, null);
            Environment.Exit(0);
        }

        /// <summary>
        /// 托盘停止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMenuStop_Click(object sender, EventArgs e)
        {
            BtnStop_Click(null, null);
        }

        /// <summary>
        /// 托盘代理启动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMenuVpn_Click(object sender, EventArgs e)
        {
            rbtnVpn.Checked = true;
            BtnStart_Click(null, null);
        }

        /// <summary>
        /// 托盘hosts启动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMenuHosts_Click(object sender, EventArgs e)
        {
            rbtnHosts.Checked = true;
            BtnStart_Click(null, null);
        }

        /// <summary>
        /// 托盘显示界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMenuShow_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        /// <summary>
        /// 启动服务方法
        /// </summary>
        private void StartServer()
        {
            //获取Node目录
            String nodePath = AppDomain.CurrentDomain.BaseDirectory + "node\\node.exe";
            //获取主程序目录
            String UnmPath = AppDomain.CurrentDomain.BaseDirectory + "UnblockNeteaseMusic\\app.js";
            if (!HostsMode) //代理模式
            {
                StartVpn(nodePath, UnmPath);
            }
            else //hosts模式
            {
                StartHosts(nodePath, UnmPath);
            }
        }

        /// <summary>
        /// 代理模式启动
        /// </summary>
        /// <param name="nodePath"></param>
        /// <param name="UnmPath"></param>
        private void StartVpn(String nodePath, String UnmPath)
        {
            new Thread((ThreadStart)delegate ()
            {
                RunCmd(nodePath + " " + UnmPath + " -a 127.0.0.1 -p " + numPort.Value + " -o kuwo kugou qq baidu");
            }).Start();
        }

        /// <summary>
        /// hosts模式启动
        /// </summary>
        /// <param name="nodePath"></param>
        /// <param name="UnmPath"></param>
        private void StartHosts(String nodePath, String UnmPath)
        {
            //获取网易云音乐IP地址
            String WYIP = GetIP("music.163.com");
            // 储存UI线程的标识符
            new Thread((ThreadStart)delegate ()
            {
                RunCmd(nodePath + " " + UnmPath + " -a 127.0.0.1 -p " + numPort.Value + " -f " + WYIP + " -o kuwo kugou qq baidu");
            }).Start();
            UpdateHost();
        }

        /// <summary>
        /// 修改hosts文件
        /// </summary>
        private void UpdateHost()
        {
            String fpath = @"C:\WINDOWS\system32\drivers\etc\hosts";
            File.SetAttributes(@fpath, FileAttributes.Normal);
            FileStream fs = new FileStream(@fpath, FileMode.Append); //写入的方式可改变，这里是追加
            StreamWriter sw = new StreamWriter(fs);
            //写入大量内容前面加 “@”符号
            sw.WriteLine(@"
127.0.0.1 music.163.com
127.0.0.1 interface.music.163.com");
            sw.Close();
            fs.Close();
        }

        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("确定要退出程序吗? \r\n你可以最小化到托盘区域,这样就不会打扰到你了。\r\n点击确定(OK)最小化\r\n点击取消(Cancel)关闭", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)   //如果单击“是”按钮
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
                this.Visible = true;
                this.Hide();
                return;
            }
            else if (res == DialogResult.Cancel)
            {
                //如果为Hosts模式则恢复
                if (HostsMode)
                {
                    RecoveryHosts();
                }
                //结束服务
                CloseSoundApp();
                this.notifyIcon1.Visible = false;
                e.Cancel = false;        //关闭窗口
            }
        }

        private void BtnAutoVpn_Click(object sender, EventArgs e)
        {
            if (!btnAutoVpn.Checked)
            {
                btnAutoVpn.Checked = true;
                btnAutoNone.Checked = btnAutoHosts.Checked = false;
            }
        }

        private void BtnAutoHosts_Click(object sender, EventArgs e)
        {
            if (!btnAutoHosts.Checked)
            {
                btnAutoHosts.Checked = true;
                btnAutoNone.Checked = btnAutoVpn.Checked = false;
            }
        }

        private void BtnAutoNone_Click(object sender, EventArgs e)
        {
            if (!btnAutoNone.Checked)
            {
                btnAutoNone.Checked = true;
                btnAutoHosts.Checked = btnAutoVpn.Checked = false;
            }
        }

        private void BtnAutoStart_CheckedChanged(object sender, EventArgs e)
        {
            btnAutoMode.Enabled = btnAutoMini.Enabled = !btnAutoStart.Checked;
        }

        /// <summary>
        /// 使用说明
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUseHelp_Click(object sender, EventArgs e)
        {
            string content = @"### 使用说明
1. 软件需要以管理员身份启动
2. 选择脚本模式，并填写端口号，个人建议用一些不常见的，不要用80端口
3. 启动脚本
4. 打开网易云设置页面
5. 在代理一栏选择自定义代理，设置ip为127.0.0.1 端口号为你刚才设置的端口号，账号密码不用管，点击确定重启网易云客户端
6. 请务必正常关闭本软件，否则可能会引起一些小问题
7. 使用hosts模式的时候会出现无法访问一些网易云音乐的站点，故不推荐此模式

### 自动启动
1. 通过菜单栏自动启动进行勾选
2. 如果需要启动后最小化,请勾选
3. 如果需要启动后自动执行脚本,请勾选脚本模式(默认关闭)";
            MessageBox.Show(content, "使用说明");
        }

        /// <summary>
        /// 更多信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMoreInfo_Click(object sender, EventArgs e)
        {
            string content = @"### 更多信息
1. 软件作者：LiuDanK
2. 软件介绍：这是一款解锁网易云音乐资源的应用，可以让你使用网易云听到平时听不到的歌曲，为你打开新世界的大门，听歌不一定就要付费。
3. 更新时间：2019年9月25日
4. BUG/建议反馈联系方式: Q3599621250";
            MessageBox.Show(content, "更多信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}