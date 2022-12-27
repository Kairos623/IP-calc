using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string toDemacial(string binary)
        {
            char[] reBinary = binary.ToCharArray();
            Array.Reverse(reBinary);
            double demacial = 0;
            int power = 0;
            foreach(char s in reBinary)
            {
                if (s is '1')
                {
                    demacial += Math.Pow(2,power);
                    power++;
                    continue;
                }
                if (s is '0')
                {
                    power++;
                }
            }
            return Convert.ToString(demacial);
        }

        private string toBinar(int demacial)
        {
            int num = demacial;
            char[] binary = new char[8];
            int i = 0;
            while (num >= 1)
            {
                if ((num % 2) == 0)
                {
                    num = num / 2;
                    binary[i] = '0';
                    i++;
                    continue;
                }
                if ((num % 2) != 0)
                {
                    num = num / 2;
                    binary[i] = '1';
                    i++;
                    continue;
                }
            }

            Array.Reverse(binary);
            return string.Join("", binary);
        }

        private string Inverse(string mask)
        {
            char[] maskarray = mask.ToCharArray();

            for(int i = 0; i < mask.Length; i++)
            {
                if (mask[i] == '1')
                {
                    maskarray[i] = '0';
                    continue;
                }
                if (mask[i] == '0')
                {
                    maskarray[i] = '1';
                    continue;
                }
            }
            return string.Join("", maskarray);
        }


        private void result_Click(object sender, EventArgs e)
        {
            //Ограничения на ввод
            if ((firstIP.Text == "") | (secondIP.Text == "") | (thirdIP.Text == "") | (fourthIP.Text == "") | (MaskUnit.Text == ""))
            {
                MessageBox.Show("Введите необходимые данные");
            }
            else
            {
                //Ввод IP по октетам
                int ip1 = Convert.ToInt32(firstIP.Text);
                int ip2 = Convert.ToInt32(secondIP.Text);
                int ip3 = Convert.ToInt32(thirdIP.Text);
                int ip4 = Convert.ToInt32(fourthIP.Text);
                //Ввод количества единиц
                int maskunit = Convert.ToInt32(MaskUnit.Text);
                //Проверка введенных данных
                if ((((ip1 < 0) & (ip1 > 255)) | ((ip2 < 0) & (ip2 > 255)) | ((ip3 < 0) & (ip3 > 255)) | ((ip4 < 0) & (ip4 > 255))) | (maskunit > 32))
                {
                    MessageBox.Show("Введите корректные данные");
                }
                else
                {
                    //Опеределение класса адреса
                    string Class;
                    if (((ip1 >= 0) & (ip1 <= 127)) & ((ip2 >= 0) & (ip2 <= 255)) & ((ip3 >= 0) & (ip3 <= 255)) & ((ip4 >= 0) & (ip4 <= 255)))
                    {
                        Class = "A";
                        IPClass.Text = Class;
                        IPNet.Text = Convert.ToString(ip1);
                    }
                    else if (((ip1 >= 128) & (ip1 <= 191)) & ((ip2 >= 0) & (ip2 <= 255)) & ((ip3 >= 0) & (ip3 <= 255)) & ((ip4 >= 0) & (ip4 <= 255)))
                    {
                        Class = "B";
                        IPClass.Text = Class;
                        IPNet.Text = Convert.ToString(ip1) + "." + Convert.ToString(ip2);
                    }
                    else if (((ip1 >= 192) & (ip1 <= 223)) & ((ip2 >= 0) & (ip2 <= 255)) & ((ip3 >= 0) & (ip3 <= 255)) & ((ip4 >= 0) & (ip4 <= 255)))
                    {
                        Class = "C";
                        IPClass.Text = Class;
                        IPNet.Text = Convert.ToString(ip1) + "." + Convert.ToString(ip2) + "." + Convert.ToString(ip3);
                    }
                    else if (((ip1 >= 224) & (ip1 <= 239)) & ((ip2 >= 0) & (ip2 <= 255)) & ((ip3 >= 0) & (ip3 <= 255)) & ((ip4 >= 0) & (ip4 <= 255)))
                    {
                        Class = "D";
                        IPClass.Text = Class;
                    }
                    else if (((ip1 >= 240) & (ip1 <= 255)) & ((ip2 >= 0) & (ip2 <= 255)) & ((ip3 >= 0) & (ip3 <= 255)) & ((ip4 >= 0) & (ip4 <= 255)))
                    {
                        Class = "E";
                        IPClass.Text = Class;
                    }


                    //Перевод октетов в двоичную систему
                    string B_ip1 = toBinar(ip1);
                    string B_ip2 = toBinar(ip2);
                    string B_ip3 = toBinar(ip3);
                    string B_ip4 = toBinar(ip4);

                    //Нахождение октетов маски (в двоичке)
                    string MaskFirstOctBin = "";
                    for (int i = 1; i <= 8; i++)
                    {
                        if (i <= maskunit)
                        {
                            MaskFirstOctBin += "1";
                            continue;
                        }

                        MaskFirstOctBin += "0";

                    }
                    string MaskSecondOctBin = "";
                    for (int i = 1; i <= 8; i++)
                    {
                        if (i <= maskunit - 8)
                        {
                            MaskSecondOctBin += "1";
                            continue;
                        }

                        MaskSecondOctBin += "0";

                    }
                    string MaskThirdOctBin = "";
                    for (int i = 1; i <= 8; i++)
                    {
                        if (i <= maskunit - 16)
                        {
                            MaskThirdOctBin += "1";
                            continue;
                        }

                        MaskThirdOctBin += "0";

                    }
                    string MaskFourthOctBin = "";
                    for (int i = 1; i <= 8; i++)
                    {
                        if (i <= maskunit - 24)
                        {
                            MaskFourthOctBin += "1";
                            continue;
                        }

                        MaskFourthOctBin += "0";

                    }

                    Mask.Text = 
                        toDemacial(MaskFirstOctBin) + "." + toDemacial(MaskSecondOctBin) + "." + toDemacial(MaskThirdOctBin) + "." + toDemacial(MaskFourthOctBin);

                    //Нахождение Ip адреса сети
                    string BinMask =  MaskFirstOctBin + MaskSecondOctBin + MaskThirdOctBin + MaskFourthOctBin;
                    string BinIp = B_ip1 + B_ip2 + B_ip3 + B_ip4;

                    string ipNetBin1 = "";
                    for(int i = 0; i < 8; i++)
                    {
                        if ((BinMask[i] == '1') && (BinIp[i] == '1'))
                        {
                            ipNetBin1 += "1";
                            continue;
                        }
                        ipNetBin1 += "0";
                    }
                    string ipNetBin2 = "";
                    for (int i = 8; i < 16; i++)
                    {
                        if ((BinMask[i] == '1') && (BinIp[i] == '1'))
                        {
                            ipNetBin2 += "1";
                            continue;
                        }
                        ipNetBin2 += "0";
                    }
                    string ipNetBin3 = "";
                    for (int i = 16; i < 24; i++)
                    {
                        if ((BinMask[i] == '1') && (BinIp[i] == '1'))
                        {
                            ipNetBin3 += "1";
                            continue;
                        }
                        ipNetBin3 += "0";
                    }
                    string ipNetBin4 = "";
                    for (int i = 24; i < 32; i++)
                    {
                        if ((BinMask[i] == '1') && (BinIp[i] == '1'))
                        {
                            ipNetBin4 += "1";
                            continue;
                        }
                        ipNetBin4 += "0";
                    }
                    IPNet.Text = toDemacial(ipNetBin1) + "." + toDemacial(ipNetBin2) + "." + toDemacial(ipNetBin3) + "." + toDemacial(ipNetBin4);

                    //Определение широковещательного адреса
                    string reversebinmask = Inverse(BinMask);
                    string binipnet = ipNetBin1 + ipNetBin2 + ipNetBin3 + ipNetBin4;

                    string broadcast1 = "";
                    for (int i = 0; i < 8; i++)
                    {
                        if ((reversebinmask[i] == '1') | (binipnet[i] == '1'))
                        {
                            broadcast1 += "1";
                            continue;
                        }
                        broadcast1 += "0";
                    }
                    string broadcast2 = "";
                    for (int i = 8; i < 16; i++)
                    {
                        if (BinMask[i] == BinIp[i])
                        {
                            broadcast2 += "1";
                            continue;
                        }
                        broadcast2 += "0";
                    }
                    string broadcast3 = "";
                    for (int i = 16; i < 24; i++)
                    {
                        if (BinMask[i] == BinIp[i])
                        {
                            broadcast3 += "1";
                            continue;
                        }
                        broadcast3 += "0";
                    }
                    string broadcast4 = "";
                    for (int i = 24; i < 32; i++)
                    {
                        if (BinMask[i] == BinIp[i])
                        {
                            broadcast4 += "1";
                            continue;
                        }
                        broadcast4 += "0";
                    }

                    ShirAd.Text = toDemacial(broadcast1) + '.' + toDemacial(broadcast2) + '.' + toDemacial(broadcast3) + '.' + toDemacial(broadcast4);

                    //Определние количества хостов
                    int numhost = 32 - maskunit;

                    double colhostint = Math.Pow(2, numhost) - 2;
                    colhost.Text = colhostint.ToString();
                }


            }
        }


        private void MaskUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void firstIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void secondIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void thirdIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void fourthIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
