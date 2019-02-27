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
    public partial class fMain : Form
    {
        //Создание окна FT232
        fFT232 ft232 = new fFT232();

        public static FTDI ftdi = new FTDI();
        public static FTDI.FT_STATUS ft_status = FTDI.FT_STATUS.FT_OK;
        public static UInt32 bytesWritten = 0;
        public static sbyte Flag2232;
        public string type;
        public static UInt32 identificator;
        private string ch = "2232";

        private UInt32 NumberFt;
        private int indexOf2232;

        public fMain()
        {
            InitializeComponent();
        }

        private void btnSearchICs_Click(object sender, EventArgs e)
        {
            lbConnectedDevices.Items.Clear();
            ft_status = ftdi.GetNumberOfDevices(ref NumberFt);
            if (ft_status != FTDI.FT_STATUS.FT_OK)
            {
                lbConnectedDevices.Items.Add("No FTDI device found!");
            }

            if (NumberFt == 0)
            {
                lbConnectedDevices.Items.Add("No FTDI device found!");
            }

            FTDI.FT_DEVICE_INFO_NODE[] ftdiDeviceList = new FTDI.FT_DEVICE_INFO_NODE[NumberFt];
            ft_status = ftdi.GetDeviceList(ftdiDeviceList);
            Flag2232 = 0;

            if (ft_status == FTDI.FT_STATUS.FT_OK)
            {
                //k - номер микросхемы
                for (UInt32 i = 0, k = 1; i < NumberFt; i++)
                {
                    type = ftdiDeviceList[i].Type.ToString(); //Считали название микросхемы
                    //if (type == "FT_DEVICE_2232H")
                    indexOf2232 = type.IndexOf(ch); 
                    if (indexOf2232!=-1) //Проверили, есть ли в названии 2232. Если нет, то это 232
                    {
                        if (Flag2232 == 0) //if we havent typed device name yet
                        {
                            lbConnectedDevices.Items.Add("Микросхема №" + String.Format("{0}: {1:x}", k++ , ftdiDeviceList[i].Type.ToString()));
                            //k++;
                            Flag2232 = 1;
                        }
                        else
                        {
                            Flag2232 = 0;
                        }
                    }
                    else
                    {
                        lbConnectedDevices.Items.Add("Микросхема №" + String.Format("{0}: {1:x}", k++, ftdiDeviceList[i].Type.ToString()));
                        //k++;
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            btnChooseIc.Enabled = false; //делаем кнопку выбора микросхемы неактивной 
        }

        private void btnChooseIc_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            string input = lbConnectedDevices.SelectedItem.ToString(); //Записали в выбранную переменную то, что в выделенной строке
            int pFrom = input.IndexOf("№") + "№".Length;
            int pTo = input.LastIndexOf(":");
            ft232.SetListBox(input.Substring(pFrom, pTo - pFrom));
            ft232.ShowDialog();
        }

        //Функция активации кнопки выбора микросхемы
        private void lbConnectedDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbConnectedDevices.SelectedIndex != -1)
            {
                btnChooseIc.Enabled = true; //Если что-то выбрали - активируем кнопку выбора микросхемы
            }
        }

        //Кнопка очистки списка микросхем
        private void btnClearListIcs_Click(object sender, EventArgs e)
        {
            lbConnectedDevices.Items.Clear();
        }
    }
}
