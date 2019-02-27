using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FTD2XX_NET;


namespace FTXX32
{
    public partial class fFT232 : Form
    {

        private String ftnumber;
        private UInt32 NumberFt;
        private string type;
        private UInt32 id;
        private static UInt32 bytesWritten = 0;
        private int indexOf2232;
        private int flagIC;
        private string ch = "2232";

        private string number_izvlechenie = "";
        private FTDI ftdi = new FTDI();
        private FTDI.FT_STATUS ft_status = FTDI.FT_STATUS.FT_OK;

        public fFT232()
        {
            InitializeComponent();
            btnHighChannel2.Enabled = false;
            btnLowChannel2.Enabled = false;
        }

        public void SetListBox(String value)
        {
            ftnumber = value;
            Vivod_v_listbox();
        }

        private void Vivod_v_listbox()
        {
            //Очищаем список
            lbFT232parameters.Items.Clear();
            //Собираем инфу о подключенных микросхемах
            ft_status = ftdi.GetNumberOfDevices(ref NumberFt);
            if (ft_status != FTDI.FT_STATUS.FT_OK)
            {
                lbFT232parameters.Items.Add("No FTDI device found!");
            }

            // Allocate storage for device info list
            FTDI.FT_DEVICE_INFO_NODE[] ftdiDeviceList = new FTDI.FT_DEVICE_INFO_NODE[NumberFt];
            ft_status = ftdi.GetDeviceList(ftdiDeviceList);
            if (ft_status == FTDI.FT_STATUS.FT_OK)
            {
                for (UInt32 i = 0; i < NumberFt; i++)
                {
                    //Выискиваем ту микросхему, номер которой передали в эту форму. Можно было и по ID...
                    type = ftdiDeviceList[i].Type.ToString();
                    //Путем склеивания формируем строку из которой будем вытаскивать число - номер микросхемы
                    string number_izvlechenie = String.Concat("Микросхема №", i + 1, ":", type);
                    int pFrom = number_izvlechenie.IndexOf("№") + "№".Length;
                    int pTo = number_izvlechenie.LastIndexOf(":");
                    string number = number_izvlechenie.Substring(pFrom, pTo - pFrom);

                    //Если микросхема та, которая выбрана в листбоксе главной формы
                    if (number == ftnumber)
                    {
                        //Определяем микросхему: 232 или 2232
                        indexOf2232 = type.IndexOf(ch);
                        if (indexOf2232 != -1) //Проверили, есть ли в названии 2232. Если нет, то это 232
                        {
                            //Задействуем кнопки подачи уровне на дополнительные каналы 2232
                            btnHighChannel2.Enabled = true;
                            btnLowChannel2.Enabled = true;
                            flagIC = 1; //Флаг того, что 2232
                            //Если совпадает и микросхема 2232 - выводим о ней всю информацию
                            lbFT232parameters.Items.Add("Device Index: " + i.ToString());
                            id = i;
                            lbFT232parameters.Items.Add("Flags: " + String.Format("{0:x}", ftdiDeviceList[i].Flags));
                            lbFT232parameters.Items.Add("Type: " + ftdiDeviceList[i].Type.ToString());
                            lbFT232parameters.Items.Add("ID: " + String.Format("{0:x}", ftdiDeviceList[i].ID));
                            lbFT232parameters.Items.Add("Location ID: " + String.Format("{0:x}", ftdiDeviceList[i].LocId));
                            lbFT232parameters.Items.Add("Serial Number: " + ftdiDeviceList[i].SerialNumber.ToString());
                            lbFT232parameters.Items.Add("Description: " + ftdiDeviceList[i].Description.ToString());

                            i++;
                            lbFT232parameters.Items.Add("------------");

                            lbFT232parameters.Items.Add("Device Index: " + i.ToString());
                            lbFT232parameters.Items.Add("Flags: " + String.Format("{0:x}", ftdiDeviceList[i].Flags));
                            lbFT232parameters.Items.Add("Type: " + ftdiDeviceList[i].Type.ToString());
                            lbFT232parameters.Items.Add("ID: " + String.Format("{0:x}", ftdiDeviceList[i].ID));
                            lbFT232parameters.Items.Add("Location ID: " + String.Format("{0:x}", ftdiDeviceList[i].LocId));
                            lbFT232parameters.Items.Add("Serial Number: " + ftdiDeviceList[i].SerialNumber.ToString());
                            lbFT232parameters.Items.Add("Description: " + ftdiDeviceList[i].Description.ToString());
                        }
                        else
                        {
                            flagIC = 0; //Флаг того, что 232
                            lbFT232parameters.Items.Add("Device Index: " + i.ToString());
                            id = i;
                            lbFT232parameters.Items.Add("Flags: " + String.Format("{0:x}", ftdiDeviceList[i].Flags));
                            lbFT232parameters.Items.Add("Type: " + ftdiDeviceList[i].Type.ToString());
                            lbFT232parameters.Items.Add("ID: " + String.Format("{0:x}", ftdiDeviceList[i].ID));
                            lbFT232parameters.Items.Add("Location ID: " + String.Format("{0:x}", ftdiDeviceList[i].LocId));
                            lbFT232parameters.Items.Add("Serial Number: " + ftdiDeviceList[i].SerialNumber.ToString());
                            lbFT232parameters.Items.Add("Description: " + ftdiDeviceList[i].Description.ToString());
                        }
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // вызываем главную форму, которая открыла текущую, главная форма всегда = 0 - [0]
            Form ifrm = Application.OpenForms[0];
            ifrm.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            ifrm.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            ifrm.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            this.Close();
            ifrm.Show(); // отображаем Form1
            //Тут еще надо остановить все процессы - подачи 0 и 1.
            ft_status = ftdi.Close();
            lbFT232parameters.Items.Clear();
            btnHighChannel2.Enabled = false;
            btnLowChannel2.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        //Кнопка подачи НИЗКОГО уровня канал 1
        private void button2_Click(object sender, EventArgs e)
        {
            if (flagIC == 1) //Если микросхема 2232
            {
                ft_status = ftdi.Close();
                ft_status = ftdi.OpenByIndex(id);
                ft_status = ftdi.SetBaudRate(9600);
                ft_status = ftdi.SetBitMode(0b11111111, 1);
                byte[] data = { 0b00000000 }; //output is low
                ft_status = ftdi.Write(data, data.Length, ref bytesWritten);
            }

            if (flagIC == 0) //Если микросхема 232
            {
                ft_status = ftdi.Close();
                ft_status = ftdi.OpenByIndex(id);
                ft_status = ftdi.SetBaudRate(9600);
                ft_status = ftdi.SetBitMode(0b11111111, 1);
                byte[] data = { 0b00000000 }; //output is low
                ft_status = ftdi.Write(data, data.Length, ref bytesWritten);
            }
        }

        //Кнопка подачи ВЫСОКОГО уровня канал 1
        private void button1_Click(object sender, EventArgs e)
        {
            ft_status = ftdi.Close();
            if (flagIC == 1) //Если микросхема 2232
            {
                ft_status = ftdi.Close();
                ft_status = ftdi.OpenByIndex(id);
                ft_status = ftdi.SetBaudRate(9600);
                ft_status = ftdi.SetBitMode(0b11111111, 1);
                byte[] data = { 0b11111111 }; //output is low
                ft_status = ftdi.Write(data, data.Length, ref bytesWritten);
            }

            if (flagIC == 0) //Если микросхема 232
            {
                ft_status = ftdi.Close();
                ft_status = ftdi.OpenByIndex(id);
                ft_status = ftdi.SetBaudRate(9600);
                ft_status = ftdi.SetBitMode(0b11111111, 1);
                byte[] data = { 0b11111111 }; //output is low
                ft_status = ftdi.Write(data, data.Length, ref bytesWritten);
            }
        }

        //Кнопка подачи ВЫСОКОГО уровня канал 2
        private void btnHighChannel2_Click(object sender, EventArgs e)
        {
            ft_status = ftdi.Close();
            //id = id + 1;
            ft_status = ftdi.OpenByIndex(++id);
            ft_status = ftdi.SetBaudRate(9600);
            ft_status = ftdi.SetBitMode(0b11111111, 1);
            byte[] data = { 0b11111111 }; //output is low
            ft_status = ftdi.Write(data, data.Length, ref bytesWritten);
            id--;
            //id=id-1;
        }

        //Кнопка подачи НИЗКОГО уровня канал 2
        private void btnLowChannel2_Click(object sender, EventArgs e)
        {
            ft_status = ftdi.Close();
            //id = id + 1;
            ft_status = ftdi.OpenByIndex(++id);
            ft_status = ftdi.SetBaudRate(9600);
            ft_status = ftdi.SetBitMode(0b11111111, 1);
            byte[] data = { 0b00000000 }; //output is low
            ft_status = ftdi.Write(data, data.Length, ref bytesWritten);
            id--;
            //id=id-1;
        }
    }
}
