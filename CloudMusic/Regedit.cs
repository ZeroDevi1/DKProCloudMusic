using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace DKProCloudMusic
{
    /// <summary>
    /// 功能描述    ：Regedit  
    /// 创 建 者    ：劉亞坤
    /// 创建日期    ：2019/9/25 11:04:29 
    /// 最后修改者  ：劉亞坤
    /// 最后修改日期：2019/9/25 11:04:29 
    /// </summary>
    class Regedit
    {
        public static bool IsRegeditItemExist()
        {
            string[] subkeyNames;
            RegistryKey hkml = Registry.LocalMachine;
            RegistryKey software = hkml.OpenSubKey("SOFTWARE");
            subkeyNames = software.GetSubKeyNames();
            //取得该项下所有子项的名称的序列，并传递给预定的数组中 
            foreach (string keyName in subkeyNames)
            //遍历整个数组 
            {
                if (keyName == "DKProCloudMusic")
                //判断子项的名称 
                {
                    hkml.Close();
                    return true;
                }
            }
            hkml.Close();
            return false;
        }
        //判断键值
        public static bool IsRegeditKeyExit()
        {
            string[] subkeyNames;
            RegistryKey hkml = Registry.LocalMachine;
            RegistryKey software = hkml.OpenSubKey("SOFTWARE\\DKProCloudMusic");
            //RegistryKey software = hkml.OpenSubKey("SOFTWARE\\test", true);
            subkeyNames = software.GetValueNames();
            //取得该项下所有键值的名称的序列，并传递给预定的数组中
            foreach (string keyName in subkeyNames)
            {
                if (keyName == "DKSet") //判断键值的名称
                {
                    hkml.Close();
                    return true;
                }
            }
            hkml.Close();
            return false;
        }
        public static void AutoRunAfterStart()
        {
            //获取当前应用程序的路径
            string localPath = Application.ExecutablePath;
            if (!System.IO.File.Exists(localPath))//判断指定文件是否存在
                return;
            RegistryKey reg = Registry.LocalMachine;
            RegistryKey run = reg.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
            //判断注册表中是否存在当前名称和值
            if (run.GetValue("DKProCloudMusic.exe") == null)
            {
                try
                {
                    run.SetValue("DKProCloudMusic.exe", localPath);
                    MessageBox.Show("已开启开机自启", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reg.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //删除注册表钟的特定值
        public static void DeleteSubKey()
        {
            RegistryKey reg = Registry.LocalMachine;
            RegistryKey run = reg.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            try
            {
                run.DeleteValue("DKProCloudMusic.exe");
                MessageBox.Show("已关闭开机自启", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reg.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
