using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Nikitin_CSharp
{
    public partial class Form1 : Form
    {
        //[DllImport("C:/Users/User/source/repos/Nikitin_LR2_sys/Debug/Nikitin_MFCLibrary.dll", CallingConvention = CallingConvention.Cdecl)] private static extern void MapSend(string str, int addr);
        [DllImport("C:/Users/User/source/repos/Nikitin_LR3_sys/Debug/Nikitin_MFCLibrary.dll", CharSet = CharSet.Ansi)] private static extern void Send(int ThreadNum, StringBuilder message);//импорт функции из dll
        [DllImport("C:/Users/User/source/repos/Nikitin_LR3_sys/Debug/Nikitin_MFCLibrary.dll", CharSet = CharSet.Ansi)] private static extern void Start();//импорт функции из dll
        [DllImport("C:/Users/User/source/repos/Nikitin_LR3_sys/Debug/Nikitin_MFCLibrary.dll", CharSet = CharSet.Ansi)] private static extern void Stop();//импорт функции из dll
        [DllImport("C:/Users/User/source/repos/Nikitin_LR3_sys/Debug/Nikitin_MFCLibrary.dll", CharSet = CharSet.Ansi)] private static extern void Quit();//импорт функции из dll
        [DllImport("C:/Users/User/source/repos/Nikitin_LR3_sys/Debug/Nikitin_MFCLibrary.dll", CharSet = CharSet.Ansi)] private static extern bool GetConfirm();//импорт функции из dll
        //Process newProcess = null;//инициализируем процесс
        //EventWaitHandle eventStart = new EventWaitHandle(false, EventResetMode.AutoReset, "StartEvent");//событие старта
        //EventWaitHandle eventConfirm = new EventWaitHandle(false, EventResetMode.AutoReset, "ConfirmEvent");//событие подтверждения
        //EventWaitHandle eventClose = new EventWaitHandle(false, EventResetMode.AutoReset, "CloseEvent");//событие закрытия потока
        //EventWaitHandle eventCloseDialog = new EventWaitHandle(false, EventResetMode.AutoReset, "CloseDialogEvent");//событие закрытия диалога
        //EventWaitHandle eventMessage = new EventWaitHandle(false, EventResetMode.AutoReset, "MessageEvent");//событие отправки сообщения
        bool flag = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void button_start_Click(object sender, EventArgs e)
        {
            if (!flag)//Если консоль не создана
            {
                //newProcess = Process.Start("C:/Users/User/source/repos/Nikitin_LR2_sys/Debug/Nikitin_LR1_sys.exe");//начинаем новый процесс
                Start();//Создаем поток
                flag = true;//Консоль открывается
                threadList.Items.Add("All threads");//добавляем пункт для выбора всех потоков
                threadList.Items.Add("Main thread");//добавляем в список главный поток
            }
            else
            {
                for (int i = 0; i < (int)threadCounter.Value; i++)
                {
                    Start();//Создаем поток
                    if (GetConfirm())
                        threadList.Items.Add((threadList.Items.Count-1).ToString() + " thread");//добавляем в список новый поток
                }
            }
            
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            if (flag)//Если консоль открыта
            {
                if (threadList.Items.Count - 2 <= 0)//если нет потоков кроме главного
                {
                    Quit();//закрываем диалог
                    if (GetConfirm())
                    {
                        flag = false;
                        threadList.Items.Remove("Main thread");//Убираем из списка поток
                        threadList.Items.Remove("All threads");//Убираем из списка надпись
                    }
                }
                else
                {
                    Stop();//останавливаем поток
                    if (GetConfirm())//Ожидаем подтверждения
                        threadList.Items.Remove((threadList.Items.Count - 2).ToString() + " thread");//Убираем из списка поток                
                }
            }
        }

        private void frmCls(object sender, FormClosedEventArgs e)
        {
            Quit();//Закрываем диалог
        }

        private void button_snd_Click(object sender, EventArgs e)
        {
            int thr = threadList.SelectedIndex;//индекс выбранного элемента в списке
            StringBuilder str = new StringBuilder(txtBox.Text);//сообщение
            int ind = 0;
            if (thr == 0)//если выбрали все потоки, то
            {
                ind = -1;
                Send(ind, str);//отправляем сообщение главному потоку
                for (int i = 2; i < threadList.Items.Count; i++)//и всем остальным
                {
                    ind = i;
                    Send(ind, str);
                }
            }
            else if (thr == 1)//если выбрали главный поток, то
            {
                ind = -1;
                Send(ind, str);//отправляем сообщение главному потоку
            }
            else//иначе
            {
                ind = thr;
                Send(ind, str);//отправляем потоку под номером, который мы выбрали в списке
            }
        }
    }
}
