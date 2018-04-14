using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Taskbar;
using MiniPomodoro.Properties;
using System.Media;

namespace MiniPomodoro
{
    public partial class Form1 : Form
    {
        private readonly decimal WorkMinutes = 0.2M; //25; // 一个番茄的时间
        private static decimal RestMinutes = 0.2M;
        private static decimal ShortRestMinutes = 0.2M; //5; // 短休息时间
        private DateTime _startTime;
        private PomodoState _currentState;
        private static decimal LongRestMinutes = 10M;//长休息时间
        private static int LongRestInterval = 4;//每四个番茄钟一个长休息
        private static int PomodoCount = 1;
        Msg msgForm = new Msg();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 打开程序自动开始一个新的工作番茄
            StartWorkPomodo();
            timer1.Start();
        }

        /// <summary>
        /// 开始一个新的工作番茄
        /// </summary>
        private void StartWorkPomodo()
        {
            _startTime = DateTime.Now;
            _currentState = PomodoState.Working;
        }

        /// <summary>
        /// 开始一个新的休息番茄
        /// </summary>
        private void StartRestPomodo()
        {
            _startTime = DateTime.Now;
            _currentState = PomodoState.Resting;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //
            // 检查是否需要切换状态
            //
            decimal elapsedMinutes = GetElapsedMinutes(); // 已经消耗的分钟数
            if (_currentState == PomodoState.Working)
            {
                if (elapsedMinutes >= WorkMinutes)
                {
                    //判断是否该长休息，如果是长休息提示用户
                    if (PomodoCount == LongRestInterval)
                    {
                        RestMinutes = LongRestMinutes;
                    }
                    else
                    {
                        RestMinutes = ShortRestMinutes;
                    }
                    PlayNotice();
                    PomodoCount = PomodoCount > LongRestInterval ? 1 : PomodoCount + 1;
                }
            }
            else if (_currentState == PomodoState.Resting)
            {
                if (elapsedMinutes >= RestMinutes)
                {
                    timer1.Stop();
                    msgForm.Close();
                    MessageBox.Show("休息时间已结束，点击按钮开始新的番茄！\r\n【番茄宣言】\r\n在某个番茄钟的过程里，如果突然想起要做什么事情:\r\na.非得马上做不可的话，停止这个番茄钟并宣告它作废（哪怕还剩5分钟就结束了），去完成这件事情，之后再重新开始同一个番茄钟；\r\n b.不是必须马上去做的话，在列表里该项任务后面标记一个逗号（表示打扰），并将这件事记在另一个列表里（比如叫“计划外事件”），然后接着完成这个番茄钟。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //if (msgForm.IsDisposed)
                    //{
                    //    msgForm = new Msg();
                    //}
                    //msgForm.SetMsgContent("请停止工作！", "已经完成了 " + PomodoCount + " 个番茄", "本次可以休息 " + RestMinutes + " 分钟", "活动一下、喝水、方便或者走走对身体有大大的好处哦。");
                    //msgForm.Show();
                    timer1.Start();
                    StartWorkPomodo();
                }
            }

            //
            // 显示效果
            //
            elapsedMinutes = GetElapsedMinutes(); // 已经消耗的分钟数
            if (_currentState == PomodoState.Working)
            {
                // 显示进度
                int progress = 100 - Convert.ToInt32(elapsedMinutes / WorkMinutes * 100);
                TaskBar.SetProgressValue(progress, TaskbarProgressBarState.Normal);

                // 显示剩余分钟数
                int leftMinitues = Convert.ToInt32(WorkMinutes - Math.Floor(elapsedMinutes));
                switch (leftMinitues)
                {
                    case 1:
                        TaskBar.SetTaskBarIcon(Resources.W1);
                        break;
                    case 2:
                        TaskBar.SetTaskBarIcon(Resources.W2);
                        break;
                    case 3:
                        TaskBar.SetTaskBarIcon(Resources.W3);
                        break;
                    case 4:
                        TaskBar.SetTaskBarIcon(Resources.W4);
                        break;
                    case 5:
                        TaskBar.SetTaskBarIcon(Resources.W5);
                        break;
                    case 6:
                        TaskBar.SetTaskBarIcon(Resources.W6);
                        break;
                    case 7:
                        TaskBar.SetTaskBarIcon(Resources.W7);
                        break;
                    case 8:
                        TaskBar.SetTaskBarIcon(Resources.W8);
                        break;
                    case 9:
                        TaskBar.SetTaskBarIcon(Resources.W9);
                        break;
                    case 10:
                        TaskBar.SetTaskBarIcon(Resources.W10);
                        break;
                    case 11:
                        TaskBar.SetTaskBarIcon(Resources.W11);
                        break;
                    case 12:
                        TaskBar.SetTaskBarIcon(Resources.W12);
                        break;
                    case 13:
                        TaskBar.SetTaskBarIcon(Resources.W13);
                        break;
                    case 14:
                        TaskBar.SetTaskBarIcon(Resources.W14);
                        break;
                    case 15:
                        TaskBar.SetTaskBarIcon(Resources.W15);
                        break;
                    case 16:
                        TaskBar.SetTaskBarIcon(Resources.W16);
                        break;
                    case 17:
                        TaskBar.SetTaskBarIcon(Resources.W17);
                        break;
                    case 18:
                        TaskBar.SetTaskBarIcon(Resources.W18);
                        break;
                    case 19:
                        TaskBar.SetTaskBarIcon(Resources.W19);
                        break;
                    case 20:
                        TaskBar.SetTaskBarIcon(Resources.W20);
                        break;
                    case 21:
                        TaskBar.SetTaskBarIcon(Resources.W21);
                        break;
                    case 22:
                        TaskBar.SetTaskBarIcon(Resources.W22);
                        break;
                    case 23:
                        TaskBar.SetTaskBarIcon(Resources.W23);
                        break;
                    case 24:
                        TaskBar.SetTaskBarIcon(Resources.W24);
                        break;
                    case 25:
                        TaskBar.SetTaskBarIcon(Resources.W25);
                        break;
                    default:
                        TaskBar.SetTaskBarIcon(Resources.W1);
                        break;
                }
            }
            else if (_currentState == PomodoState.Resting)
            {
                int progress = 100 - Convert.ToInt32(elapsedMinutes / RestMinutes * 100);
                int currentSecond = DateTime.Now.Second;
                if (currentSecond % 2 == 0)
                {
                    // 显示剩余分钟数
                    TaskBar.SetTaskBarIcon(Resources.R5);
                    // 显示进度
                    TaskBar.SetProgressValue(progress, TaskbarProgressBarState.Paused);
                }
                else
                {
                    // 进度闪烁
                    TaskBar.ClearProgressValue();
                }
            }
        }

        /// <summary>
        /// 播放声音,播放一次
        /// </summary>
        private void PlayNotice()
        {

            //string soundPath = Application.StartupPath+@"\res\sound\iPhone7.wav";
            StartRestPomodo();
            SoundPlayer player = new SoundPlayer(Resources.iPhone7);
            player.Load();
            player.Play();
            if (msgForm.IsDisposed)
            {
                msgForm = new Msg();
            }
            msgForm.SetMsgContent("请停止工作！", "已经完成了 " + PomodoCount + " 个番茄", "本次可以休息 " + RestMinutes + " 分钟","活动一下、喝水、方便或者走走对身体有大大的好处哦。");
            msgForm.Show();
        }

        /// <summary>
        /// 返回已经消耗了多少分钟
        /// </summary>
        /// <returns></returns>
        private decimal GetElapsedMinutes()
        {
            return Convert.ToDecimal((DateTime.Now - _startTime).TotalMinutes);
        }
    }

    public enum PomodoState
    {
        Working = 0,
        Resting = 1
    }
}
